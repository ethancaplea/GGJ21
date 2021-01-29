using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BasicEnemyBehavior : MonoBehaviour
{
    Collider collider;  // the enemy's collider component
    public int health = 10;    // the health before the enemy dies
    public int damage = 1;     // the damage the enemy does in a single attack
    public GameObject target;   // what the enemy is moving towards
    Vector3 targetDirection;  // the direction towards the target
    NavMeshAgent agent;     // the navigation component


    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        collider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        #region movement towards the target
        // set the enemy to follow the target
        targetDirection = target.transform.position;
        agent.SetDestination(targetDirection);
        #endregion

        #region combat with player

        // enemy is at 0 health so it is destroyed
        if (health == 0)
        {
            Destroy(gameObject);
        }
        #endregion

    }
}
