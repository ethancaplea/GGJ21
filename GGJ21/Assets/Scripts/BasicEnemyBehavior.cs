using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemyBehavior : MonoBehaviour
{
    public GameObject target;   // what the enemy is moving towards
    Vector3 targetDirection;  // the direction towards the target
    NavMeshAgent agent;     // the navigation component


    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // set the enemy to follow the target
        targetDirection = target.transform.position;
        agent.SetDestination(targetDirection);
    }
}
