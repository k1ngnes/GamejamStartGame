using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    [SerializeField] private int damage = 10;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private GameObject vaporEffect;
    [SerializeField] private float timeToLive = 10f;


    private void Start()
    {
        rb.velocity = transform.right * speed;
    }

    private void Update()
    {
        if (timeToLive > 0)
        {
            timeToLive -= 0.01f;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Fire fire = hitInfo.GetComponent<Fire>();
        if (fire != null)
        {
            fire.TakeDamage(damage);
            Destroy(gameObject);
        }
        BurningLog log = hitInfo.GetComponent<BurningLog>();
        if (log != null)
        {
            if (log.TakeDamage(damage) == 1)
            {
                Destroy(gameObject);
            }
        }
    }
}
