using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject waterPrefab;
    [SerializeField] private PlayerController playerController;
    private Camera mainCam;
    private Vector3 mousePos;
    private int maxWaterAmmo = 60000;
    private int currentWaterAmmo;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject ammoBar;
    [SerializeField] private GameObject waterParticle;
    [SerializeField] private GameObject dialogManager;
    private DialogueManager dm;

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        currentWaterAmmo = maxWaterAmmo;
        animator = ammoBar.GetComponent<Animator>();
        dm = dialogManager.GetComponent<DialogueManager>();
    }

    void Update()
    {

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        if (currentWaterAmmo > 500 && currentWaterAmmo < 550)
        {
            animator.SetInteger("state", 1);
        }
        else if (currentWaterAmmo > 450 && currentWaterAmmo < 500)
        {
            animator.SetInteger("state", 2);
        }
        else if (currentWaterAmmo > 400 && currentWaterAmmo < 450)
        {
            animator.SetInteger("state", 3);
        }
        else if (currentWaterAmmo > 350 && currentWaterAmmo < 400)
        {
            animator.SetInteger("state", 4);
        }
        else if (currentWaterAmmo > 300 && currentWaterAmmo < 350)
        {
            animator.SetInteger("state", 5);
        }
        else if (currentWaterAmmo > 250 && currentWaterAmmo < 300)
        {
            animator.SetInteger("state", 6);
        }
        else if (currentWaterAmmo > 200 && currentWaterAmmo < 250)
        {
            animator.SetInteger("state", 7);
        }
        else if (currentWaterAmmo > 150 && currentWaterAmmo < 200)
        {
            animator.SetInteger("state", 8);
        }
        else if (currentWaterAmmo > 100 && currentWaterAmmo < 150)
        {
            animator.SetInteger("state", 9);
        }
        else if (currentWaterAmmo > 75 && currentWaterAmmo < 100)
        {
            animator.SetInteger("state", 10);
        }
        else if (currentWaterAmmo > 50 && currentWaterAmmo < 75)
        {
            animator.SetInteger("state", 11);
        }
        else if (currentWaterAmmo > 0 && currentWaterAmmo < 50)
        {
            animator.SetInteger("state", 12);
        }
        else if (currentWaterAmmo <= 0)
        {
            animator.SetInteger("state", 13);
        }

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        if (playerController.GetIsFacingRight())
        {
            if (rotZ > 80)
            {
                rotZ = 80;
            }
            if (rotZ < -80)
            {
                rotZ = -80;
            }     
        }
        else if (!playerController.GetIsFacingRight())
        {
            if (rotZ < 100 && rotZ > 0)
            {
                rotZ = 100;
            }
            if (rotZ > -100 && rotZ < 0)
            {
                rotZ = -100;
            }
        }
        if (playerController.GetIsFacingRight())
        {
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
        else
        {
            transform.rotation = Quaternion.Euler(180, 0, -rotZ);
        }
        if (Input.GetKey(KeyCode.Mouse0) && playerController.GetIsTankOn() && currentWaterAmmo > 0 && !dm.DialogueActive)
        {
            Shoot();
            Instantiate(waterParticle, firePoint.position, transform.rotation);
            currentWaterAmmo -= 1;
        }
    }

    public void Reload()
    {
        currentWaterAmmo = 100;
    }

    public int GetWaterAmmo()
    {
        return currentWaterAmmo;
    }

    private void Shoot()
    {
        Instantiate(waterPrefab, firePoint.position, firePoint.rotation);
    }
}
