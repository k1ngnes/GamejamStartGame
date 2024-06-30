using Articy.Jam.GlobalVariables;
using Articy.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInteraction : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject buttonHint;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;
    [SerializeField] GameObject hint;
    private Animator animator;

    private void Start()
    {
        animator = hint.GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D interaction = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (interaction != null)
            {
                var articyReferenceComp = interaction.gameObject.GetComponent<ArticyReference>();
                if (articyReferenceComp)
                {
                    availableDialogue = articyReferenceComp.reference.GetObject();
                }
                Debug.Log(animator.GetInteger("state"));
                if (animator.GetInteger("state") == 2)
                {
                    ArticyGlobalVariables.Default.GameState.training_complete = true;
                }
                dialogueManager.StartDialogue(availableDialogue);
            }
        }
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueManager.CloseDialogueBox();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ArticyReference tank = collision.GetComponent<ArticyReference>();
        if (tank != null)
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
        ArticyReference tank = collision.GetComponent<ArticyReference>();
        if (tank != null)
        {
            animator.SetInteger("state", 0);
        }
    }
}