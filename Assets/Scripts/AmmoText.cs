using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoText : MonoBehaviour
{
    [SerializeField] private Slider slider;

    public void SetMaxWaterAmmo(int maxWaterAmmo)
    {
        slider.maxValue = maxWaterAmmo;
    }

    public void UpdateAmmoText(int currentAmmo)
    {
        slider.value = currentAmmo;
    }

}
