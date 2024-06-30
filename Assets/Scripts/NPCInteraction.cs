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
    private GameObject interactedNPC;
    [SerializeField] private DialogueManager dialogueManager;
    private ArticyObject availableDialogue;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D interaction = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (interaction != null)
            {
                interactedNPC = interaction.gameObject;
                var articyReferenceComp = interactedNPC.GetComponent<ArticyReference>();
                if (articyReferenceComp)
                {
                    availableDialogue = articyReferenceComp.reference.GetObject();
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
        Dialogues dialogue = collision.GetComponent<Dialogues>();
        if (dialogue != null)
        {
            Instantiate(buttonHint, transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity);
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
    }
}