using Articy.Unity;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Articy.Jam.GlobalVariables;

public class RichPickUp : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private Rich rich;
    [SerializeField] GameObject hint;
    private Animator animator;
    [SerializeField] private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;


    private void Start()
    {
        animator = hint.GetComponent<Animator>();
    }

    public void WearRich()
    {
        //if (ArticyGlobalVariables.Default.GameState.best_choice)
        playerController.SetIsRichOn(true);

        rich.RichPickUp();
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
                dialogueManager.StartDialogue(availableDialogue, pickedUpItem.gameObject);
            }
        }
        if (dialogueManager.DialogueActive && Input.GetKeyDown(KeyCode.Escape))
        {
            dialogueManager.CloseDialogueBox();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Tank tank = collision.GetComponent<Tank>();
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
        Tank tank = collision.GetComponent<Tank>();
        if (tank != null)
        {
            animator.SetInteger("state", 0);
        }
    }

}