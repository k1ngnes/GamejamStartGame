using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithNPC : MonoBehaviour
{
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject buttonHint;
    [SerializeField] private LayerMask pickUpMask;
    [SerializeField] private float pickUpRadius = 0.4f;
    [SerializeField] private  tank;

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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Tank tank = collision.GetComponent<Tank>();
        if (tank != null)
        {
            Instantiate(buttonHint, transform.position + new Vector3(0f, 2f, 0f), Quaternion.identity);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Destroy(buttonHint);
    }
}
