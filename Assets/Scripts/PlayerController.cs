using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float maxSpeed = 5f;
    [SerializeField] private float jumpPower = 1f;
    private float horizontal;
    private bool isFacingRight = true;
    [SerializeField] private bool isTankOn = false;
    [SerializeField] private bool isCostumeOn = false;
    private bool isGrounded;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Weapon weapon;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        Flip();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
            animator.SetBool("isJumping", !isGrounded);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * maxSpeed, rb.velocity.y);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
        animator.SetFloat("yVelocity", rb.velocity.y);
    }

    public bool GetIsFacingRight()
    {
        return isFacingRight;
    }

    public void SetIsTankOn(bool value)
    {
        isTankOn = value;
    }

    public bool GetIsTankOn() 
    {
        return isTankOn;
    }

    public void SetIsCostumeOn(bool value)
    {
        isCostumeOn = value;
    }

    public bool GetIsCostumeOn()
    {
        return isCostumeOn;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        animator.SetBool("isJumping", false);
    }

    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            transform.Rotate(0f, 180f, 0f);
            weapon.transform.Rotate(180f, 0f, 0f);
        }
    }
}
