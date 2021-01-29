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
    public bool fruitFlag;
    public bool trapFlag;
    public float timer = 5;
    float resettimer;


    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        collider = gameObject.GetComponent<Collider>();
        timer = resettimer;
    }

    // Update is called once per frame
    void Update()
    {
        #region movement towards the target
        // set the enemy to follow the target
        if (fruitFlag == true)
        {
            targetDirection = target.transform.position * (0.5f);
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                fruitFlag = false;
                timer = resettimer;
            }
        }
        else
        {
            targetDirection = target.transform.position;
        }

        if (trapFlag == true)
        {
            agent.speed = 0;
            if (timer > 0)
            {
                timer -= Time.deltaTime;
            }
            else
            {
                trapFlag = false;
                timer = resettimer;
            }
        }
        else
        {
            agent.speed = 10;
        }
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
