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
    private int maxWaterAmmo = 1000;
    private int currentWaterAmmo;
    [SerializeField] private AmmoText ammoBar;
    [SerializeField] private GameObject waterParticle;
    [SerializeField] private GameObject dialogManager;

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        currentWaterAmmo = maxWaterAmmo;
        ammoBar.SetMaxWaterAmmo(maxWaterAmmo);
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
        if (Input.GetKey(KeyCode.Mouse0) && playerController.GetIsTankOn() && currentWaterAmmo > 0 && !dialogManager.GetComponent<DialogueManager>().DialogueActive)
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
