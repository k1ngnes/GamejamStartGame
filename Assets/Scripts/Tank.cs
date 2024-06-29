using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{

    public void TankPickUp()
    {
        Destroy(gameObject);
    }
}
