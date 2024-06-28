using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CostumePickUp : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private Costume costume;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D pickedUpItem = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (pickedUpItem != null)
            {
                playerController.SetIsCostumeOn(true);
                costume.CostumePickUp();
            }
        }
    }
}
