using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject firePutOutEffect;

    public void TakeDamage(int damage)
    {
        if (health <= 0)
        {
            Die();
        }
        else
        {
            health -= damage;
            Debug.Log(health);
        }
    }

    private void Die()
    {
        Instantiate(firePutOutEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Loader.Load(Loader.Scene.RespawnScene);
        }
    }
}
