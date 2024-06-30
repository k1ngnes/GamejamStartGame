using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Articy.Unity;
using Articy.Unity.Interfaces;
using Articy.Jam;
using Articy.Jam.GlobalVariables;
using Unity.Burst.CompilerServices;

public class DialogueManager : MonoBehaviour, IArticyFlowPlayerCallbacks
{
    [Header("UI")]
    // Reference to Dialog UI
    [SerializeField]
    GameObject dialogueWidget;
    // Reference to dialogue text
    [SerializeField]
    Text dialogueText;
    // Reference to speaker
    [SerializeField]
    Text dialogueSpeaker;
    // Reference to button layout
    [SerializeField]
    RectTransform branchLayoutPanel;
    // Reference to navigation button prefab
    [SerializeField]
    GameObject branchPrefab;
    // Reference to close button prefab
    [SerializeField]
    GameObject closePrefab;
    [SerializeField]
    GameObject player;
    [SerializeField] GameObject wood;
    private Animator animator;
    private TankPickUp tankPickUp;
    private CostumePickUp costumePickUp;
    private string item = "none";
    private bool ifLastDialogLine = false; //set true when appear last dialog line of dialog

    // To check if we are currently showing the dialog ui interface
    public bool DialogueActive { get; set; }

    private ArticyFlowPlayer flowPlayer;
    private int selectedButtonIndex = 0;

    void Start()
    {
        flowPlayer = GetComponent<ArticyFlowPlayer>();
        tankPickUp = player.GetComponent<TankPickUp>();
        costumePickUp = player.GetComponent<CostumePickUp>();
        animator = wood.GetComponent<Animator>();
    }

    void Update()
    {
        // Check if the dialogue is active and there are child elements in the branch layout panel
        if (DialogueActive && branchLayoutPanel != null && branchLayoutPanel.childCount > 0)
        {
            // Ensure selectedButtonIndex is within bounds
            selectedButtonIndex = Mathf.Clamp(selectedButtonIndex, 0, branchLayoutPanel.childCount - 1);

            if (Input.GetKeyDown(KeyCode.Return)) // KeyCode.Return - клавиша Enter
            {
                Button currentButton = branchLayoutPanel.GetChild(selectedButtonIndex).GetComponent<Button>();
                currentButton.onClick.Invoke();
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                selectedButtonIndex = (selectedButtonIndex > 0) ? selectedButtonIndex - 1 : branchLayoutPanel.childCount - 1;
                HighlightSelectedButton();
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                selectedButtonIndex = (selectedButtonIndex < branchLayoutPanel.childCount - 1) ? selectedButtonIndex + 1 : 0;
                HighlightSelectedButton();
            }
        }
    }

    void HighlightSelectedButton()
    {
        for (int i = 0; i < branchLayoutPanel.childCount; i++)
        {
            Button button = branchLayoutPanel.GetChild(i).GetComponent<Button>();
            ColorBlock colors = button.colors;
            colors.normalColor = (i == selectedButtonIndex) ? Color.yellow : Color.white;
            button.colors = colors;
        }
    }

    public void StartDialogue(IArticyObject aObject)
    {
        item = "none";
        DialogueActive = true;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.StartOn = aObject;
    }

    public void StartDialogue(IArticyObject aObject, GameObject aItem)
    {
        item = "none";
        DialogueActive = true;
        dialogueWidget.SetActive(DialogueActive);
        flowPlayer.StartOn = aObject;

        if (aItem != null)
        {
            Tank tankComponent = aItem.GetComponent<Tank>();
            Costume costumeComponent = aItem.GetComponent<Costume>();

            if (tankComponent != null)
            {
                item = "tank";
            }
            if (costumeComponent != null)
            {
                item = "costume";
            }
        }
    }

    public void CloseDialogueBox()
    {
        DialogueActive = false;
        dialogueWidget.SetActive(DialogueActive);
        // Completely process current object before we end dialogue
        flowPlayer.FinishCurrentPausedObject();
    }

    // This is called every time the flow player reaches an object of interest
    public void OnFlowPlayerPaused(IFlowObject aObject)
    {
        //Clear data
        dialogueText.text = string.Empty;
        dialogueSpeaker.text = string.Empty;

        // If we paused on an object that has a "Text" property fetch this text and present it
        var objectWithText = aObject as IObjectWithText;
        if (objectWithText != null)
        {
            dialogueText.text = objectWithText.Text;
        }

        // If the object has a "Speaker" property try to fetch the speaker
        var objectWithSpeaker = aObject as IObjectWithSpeaker;
        if (objectWithSpeaker != null)
        {
            // If the object has a "Speaker" property, fetch the reference
            // and ensure it is really set to an "Entity" object to get its "DisplayName"
            var speakerEntity = objectWithSpeaker.Speaker as Entity;
            if (speakerEntity != null)
            {
                dialogueSpeaker.text = speakerEntity.DisplayName;
            }
        }
    }

    // Called every time the flow player encounters multiple branches,
    // or is paused on a node and wants to tell us how to continue
    public void OnBranchesUpdated(IList<Branch> aBranches)
    {
        // Destroy buttons from previous use, will create new ones here
        ClearAllBranches();

        // Check if any branch leads to a DialogueFragment target
        // If so, the dialogue is not yet finished
        bool dialogueIsFinished = true;
        foreach (var branch in aBranches)
        {
            if (branch.Target is IDialogueFragment)
            {
                dialogueIsFinished = false;
            }
        }
        if (!ArticyGlobalVariables.Default.GameState.allow_take_hose)
        {
            ifLastDialogLine = true;
        }
        if (dialogueIsFinished && !ifLastDialogLine && item != "none")
        {
            ifLastDialogLine = true;
            dialogueIsFinished = false;
        }
        if (!dialogueIsFinished)
        {
            // If we have branches, create a button for each of them
            foreach (var branch in aBranches)
            {
                // Instantiate a button in the Dialogue UI
                GameObject btn = Instantiate(branchPrefab, branchLayoutPanel);
                // Let the BranchChoice component fill the button content
                btn.GetComponent<BranchChoice>().AssignBranch(flowPlayer, branch);
            }
        }
        else
        {
            Debug.Log(item);
            if (item == "tank" && ArticyGlobalVariables.Default.GameState.allow_take_hose)
            {
                tankPickUp.WearTank();
                ifLastDialogLine = false;
            }
            if (item == "costume")
            {
                costumePickUp.WearCostume();
                ifLastDialogLine = false;
            }
            if (ArticyGlobalVariables.Default.GameState.training)
            {
                animator.SetInteger("state", 1);
            }
            // Dialogue is finished, instantiate a close button
            GameObject btn = Instantiate(closePrefab, branchLayoutPanel);
            // Clicking this button will close the Dialogue UI
            var btnComp = btn.GetComponent<Button>();
            btnComp.onClick.AddListener(CloseDialogueBox);
        }

        // Reset selected button index
        selectedButtonIndex = 0;
        if (branchLayoutPanel.childCount > 0)
        {
            HighlightSelectedButton();
        }
    }

    // Delete buttons from previous branches
    void ClearAllBranches()
    {
        foreach (Transform child in branchLayoutPanel)
        {
            Destroy(child.gameObject);
        }
    }
}