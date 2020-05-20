using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{
    public Camera playerCamera;
    private float camVertAngle = 0;
    void Update()
    {
        UpdateCameraRotation();
    }
    float LookInputX()
    {
        return Input.GetAxisRaw("Mouse X");
    }

    float LookInputY()
    {
        return Input.GetAxisRaw("Mouse Y");
    }

    void UpdateCameraRotation()
    {
        // Horizontal rotation
        transform.Rotate(Vector3.up, LookInputX());

        // Vertical rotation
        camVertAngle += LookInputY();
        camVertAngle = Mathf.Clamp(camVertAngle, -89f, 89f);
        playerCamera.transform.localEulerAngles = new Vector3(-camVertAngle, 0 , 0);
    }
}
