using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraScript : MonoBehaviour
{
    public Camera playerCamera;
    private float camVertAngle = 0;
    public float sens;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        UpdateCameraRotation();
        UpdateCursorState();
    }
    float LookInputX()
    {
        return Input.GetAxisRaw("Mouse X") * sens;
    }

    float LookInputY()
    {
        return Input.GetAxisRaw("Mouse Y") * sens;
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

    void UpdateCursorState()
    {
        // Lock on Left Click
        if (Input.GetMouseButtonDown(0)) Cursor.lockState = CursorLockMode.Locked;
        
        // Unlock on Escape
        if (Input.GetKeyDown(KeyCode.Escape)) Cursor.lockState = CursorLockMode.None;
    }

}
