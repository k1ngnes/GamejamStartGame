using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private float xOffset = 0f;
    private float yOffset = 0f;
    private float zOffset = -10f;
    private float smoothTime = 0.1f;
    private Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    void Update()
    {
        Vector3 targetPosition = new Vector3(target.position.x + xOffset, transform.position.y + yOffset, target.position.z + zOffset);
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
