using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset;
    public float sensitivity;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + transform.forward * offset.z;
        transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Mouse X") * sensitivity);
    }
}