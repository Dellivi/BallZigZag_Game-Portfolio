using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;

    [SerializeField] private float distanceY = 10f;
    [SerializeField] private float distanceX = -4f;
    [SerializeField] private float distanceZ = 5f;

    private Vector3 offsetY;

    void Start()
    {
        offsetY = new Vector3(distanceX, distanceY, distanceZ);
    }

    void LateUpdate()
    {
        transform.position = player.position + offsetY;

        transform.LookAt(player.position);
    }
}
