using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Camera cam;

    [SerializeField] private float distanceY = 10f;
    [SerializeField] private float distanceX = -4f;
    [SerializeField] private float distanceZ = 5f;

    private Vector3 offsetY;

    void Start()
    {
        cam = Camera.main;
        offsetY = new Vector3(distanceX, distanceY, distanceZ);
    }

    void LateUpdate()
    {
        cam.transform.position = player.position + offsetY;

        cam.transform.LookAt(player.position);
    }
}
