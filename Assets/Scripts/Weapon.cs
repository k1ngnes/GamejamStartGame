using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject waterPrefab;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private GameObject player;
    private Camera mainCam;
    private Vector3 mousePos;
    private int maxWaterAmmo = 100;
    private int currentWaterAmmo;
    [SerializeField] private AmmoText ammoBar;
    private Rigidbody2D rb;

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        currentWaterAmmo = maxWaterAmmo;
        ammoBar.SetMaxWaterAmmo(maxWaterAmmo);
        rb = player.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ammoBar.UpdateAmmoText(currentWaterAmmo);

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;
        if (playerController.GetIsFacingRight())
        {
            if (rotZ > 80)
            {
                rotZ = 80;
                rb.velocity = new Vector2(-0.1f, rb.velocity.y);
                playerController.Flip();
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
        if (Input.GetKey(KeyCode.Mouse0) && playerController.GetIsTankOn() && currentWaterAmmo > 0)
        {
            Shoot();
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
