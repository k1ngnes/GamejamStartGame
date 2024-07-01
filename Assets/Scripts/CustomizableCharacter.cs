using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizableCharacter : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        SkinChoice();
    }

    private void SkinChoice() 
    {
        if (playerController.GetIsCostumeOn() && !playerController.GetIsTankOn())
        {
            animator.SetInteger("skinNumber", 1);
        }
        if (playerController.GetIsTankOn() && playerController.GetIsCostumeOn())
        {
            animator.SetInteger("skinNumber", 2);
        }
        if (playerController.GetIsHipsterOn())
        {
            animator.SetInteger("skinNumber", 3);
        }
        if (playerController.GetIsNakedOn())
        {
            animator.SetInteger("skinNumber", 4);
        }
        if (playerController.GetIsWomanOn())
        {
            animator.SetInteger("skinNumber", 5);
        }
    }
}
