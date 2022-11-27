using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TutEnemy : MonoBehaviour
{
    public Transform target;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<NavMeshAgent>().SetDestination(target.position);
        }
    }
}
