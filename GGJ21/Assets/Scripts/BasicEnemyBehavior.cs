using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

/// <summary>
/// This script covers all enemy behavior
/// </summary>

public class BasicEnemyBehavior : MonoBehaviour
{
    public int health;    // the health before the enemy dies
    public int damage;     // the damage the enemy does in a single attack
    GameObject player;      // the player is the target
    Vector3 targetDirection;  // the direction towards the target
    NavMeshAgent agent;     // the navigation component
    public bool fruitFlag;
    public bool trapFlag;
    public float timer;
    float resettimer;

    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();    // get navMesh component
        player = GameObject.Find("player");
        timer = resettimer;
    }

    // Update is called once per frame
    void Update()
    {
        #region movement towards the target
        // set the enemy to follow the target
        targetDirection = player.transform.position;
        agent.SetDestination(targetDirection);

        #region fruit stuff
        //if (fruitFlag == true)
        //{
        //    targetDirection = target.transform.position * (0.5f);
        //    if (timer > 0)
        //    {
        //        timer -= Time.deltaTime;
        //    }
        //    else
        //    {
        //        fruitFlag = false;
        //        timer = resettimer;
        //    }
        //}
        //else
        //{
        //    targetDirection = target.transform.position;
        //}

        //if (trapFlag == true)
        //{
        //    agent.speed = 0;
        //    if (timer > 0)
        //    {
        //        timer -= Time.deltaTime;
        //    }
        //    else
        //    {
        //        trapFlag = false;
        //        timer = resettimer;
        //    }
        //}
        //else
        //{
        //    agent.speed = 10;
        //}
        //agent.SetDestination(targetDirection);

        #endregion

        #endregion

        #region combat with player

        // attack player


        // enemy is at 0 health so it is destroyed
        if (health == 0)
        {
            Destroy(gameObject);
        }
        #endregion

    }
}
