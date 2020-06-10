using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour
{
    public Camera playerCamera;

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            Fire();
        }
    }

    void Fire()
    {
        // Check for impact. If absent, return.
        RaycastHit hit;
        if (!Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, Mathf.Infinity)) return;

        // Check if Zombie is hit
        if (hit.collider.gameObject.tag == "Zombie") {
            HealthBase zombie = hit.collider.gameObject.GetComponent<HealthBase>();
            zombie.TakeDamage(1);
        }
    }
}
