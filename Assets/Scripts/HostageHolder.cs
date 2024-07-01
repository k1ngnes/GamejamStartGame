using Articy.Jam.GlobalVariables;
using Articy.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HostageHolder : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private HostageHold hostageHold;
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
            Collider2D pickedUpItem = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (pickedUpItem != null)
            {
                if(playerController.GetIsHipsterOn())
                {
                    playerController.SetIsHipsterOn(false);
                }
                if (playerController.GetIsWomanOn())
                {
                    playerController.SetIsWomanOn(false);
                }
                if (playerController.GetIsRichOn())
                {
                    playerController.SetIsRichOn(false);
                }
                if (playerController.GetIsNakedOn())
                {
                    playerController.SetIsNakedOn(false);
                }
            }
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
        ArticyReference tank = collision.GetComponent<ArticyReference>();
        if (tank != null)
        {
            animator.SetInteger("state", 0);
        }
    }
}