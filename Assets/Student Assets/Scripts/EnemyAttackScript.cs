﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    private IEnumerator attack;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            attack = Attack(collider.gameObject.GetComponent<HealthBase>(), 2.0f);
            StartCoroutine(attack);
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "Player") {
            StopCoroutine(attack);
        }
    }
    IEnumerator Attack(HealthBase target, float interval)
    {
        while (!target.Dead()) {
            target.TakeDamage(1);

            yield return new WaitForSeconds(interval);
        }

    }
}
