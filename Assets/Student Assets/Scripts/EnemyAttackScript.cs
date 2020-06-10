using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackScript : MonoBehaviour
{
    IEnumerator Attack(HealthBase target, float interval)
    {
        while (!target.Dead()) {
            target.TakeDamage(1);

            yield return new WaitForSeconds(interval);
        }

    }
}
