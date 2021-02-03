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
        //transform.position = player.transform.position + offset;
        //transform.LookAt(player.transform);
        transform.position = player.transform.position + transform.forward * offset.z;
        transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Mouse X") * sensitivity);
    }
}

/*public GameObject player;
private Vector3 offset;

float distance;
Vector3 playerInitialPosition;
Vector3 playerDirecton;

// Start is called before the first frame update
void Start()
{
    offset = transform.position - player.transform.position;

    distance = offset.magnitude;
    playerInitialPosition = player.transform.position;
}

// Update is called once per frame
void LateUpdate()
{
    //transform.position = player.transform.position + offset;
    playerDirecton = player.transform.position - playerInitialPosition;
    if (playerDirecton != Vector3.zero)
    {
        float yy = transform.position.y;
        yy = 4f;

        playerDirecton.Normalize();
        transform.position = player.transform.position - playerDirecton * distance;

        transform.position = new Vector3(transform.position.x, yy, transform.position.z);

        transform.LookAt(player.transform.position);

        playerInitialPosition = player.transform.position;
    }
} */