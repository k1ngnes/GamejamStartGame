using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject firePutOutEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Instantiate(firePutOutEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    } 
        
}
