using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankPickUp : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private Tank tank;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider2D pickedUpItem = Physics2D.OverlapCircle(transform.position, pickUpRadius, pickUpMask);
            if (pickedUpItem != null)
            {
                playerController.SetIsTankOn(true);
                tank.TankPickUp();
            }
        }
    }
    
}
