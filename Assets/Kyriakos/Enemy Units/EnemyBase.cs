using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public abstract class EnemyBase : MonoBehaviour
{
    public string name;

    public int healthPrecentage = 100;

    public NavMeshAgent agent;

    public EnemyData data;

    public abstract void Initiate(EnemyData data);

    public abstract void Attack();
}