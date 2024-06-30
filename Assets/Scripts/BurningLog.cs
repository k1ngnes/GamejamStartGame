using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BurningLog : MonoBehaviour
{
    [SerializeField] private int health = 100;
    [SerializeField] private GameObject firePutOutEffect;
    private Animator animator;
    [SerializeField] private int respawnScene;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public int TakeDamage(int damage)
    {
        if (animator.GetInteger("state") == 1)
        {
            health -= damage;
            return 1;
        }
        if (health <= 0)
        {
            Die();
            return 2;
        }

        return 0;
    }

    private void Die()
    {
        Instantiate(firePutOutEffect, transform.position, Quaternion.identity);
        animator.SetInteger("state", 2);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (animator.GetInteger("state") == 1 && collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Testing 1");
        }
    }
}
