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

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D interaction = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (interaction != null)
            {
                interactedNPC = interaction.gameObject;

                switch (interactedNPC.name)
                {
                    case "NPCName(ObjectName)":
                        //Here we can use public method from any npc dialogue
                        break;
                    default:
                        break;
                }
            }
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
        Destroy(buttonHint);
    }
}
