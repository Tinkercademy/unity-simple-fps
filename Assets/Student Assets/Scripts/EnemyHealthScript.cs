using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthScript : HealthBase
{
    public int initHealth;

    void Start()
    {
        health = initHealth;
    }
}
