using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNavScript : MonoBehaviour
{
    public NavMeshAgent agent;
    public PlayerData playerData;

    void Update()
    {
        agent.SetDestination(playerData.playerPos);
    }
}
