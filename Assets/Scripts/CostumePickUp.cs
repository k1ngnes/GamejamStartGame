using Articy.Jam.GlobalVariables;
using Articy.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumePickUp : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private Costume costume;
    [SerializeField] private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;
    [SerializeField] GameObject hint;
    private Animator animator;

    private void Start()
    {
        animator = hint.GetComponent<Animator>();
    }

    public void WearCostume()
    {
        playerController.SetIsCostumeOn(true);
        costume.CostumePickUp();
        ArticyGlobalVariables.Default.GameState.allow_take_hose = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D pickedUpItem = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (pickedUpItem != null)
            {
                var articyReferenceComp = pickedUpItem.gameObject.GetComponent<ArticyReference>();
                if (articyReferenceComp)
                {
                    availableDialogue = articyReferenceComp.reference.GetObject();
                }
                dialogueManager.StartDialogue(availableDialogue, pickedUpItem.gameObject); // передаем предмет
            }
        }
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueManager.CloseDialogueBox();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Costume costume = collision.GetComponent<Costume>();
        if (costume != null)
        {
            animator.SetInteger("state", 1);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<ArticyReference>() != null)
        {
            availableDialogue = null;
        }
        if (dialogueManager.DialogueActive)
        {
            dialogueManager.CloseDialogueBox();
        }
        Costume costume = collision.GetComponent<Costume>();
        if (costume != null)
        {
            animator.SetInteger("state", 0);
        }
    }
}