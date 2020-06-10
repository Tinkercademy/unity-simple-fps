using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthScript : HealthBase
{
    public int initHealth;
    
    void Start()
    {
        health = initHealth;
    }

    public override void Die()
    {
        Debug.Log("I seem to be dead");
    }
}
