using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject characterRadius;
    public GameObject characterBody;
    public float health;
    public float timer;
    private float reset;
    private GameObject weapon;//need to be looking at the monsters damage/weapon
    private int damageTaken;
    private float startHealth;
    // Start is called before the first frame update
    void Start()
    {
        startHealth = health;
        reset = timer;
    }

    // Update is called once per frame
    void Update()
    {
        //if the health falls below 0 character dies
        if(health < 0)
        {
            //if check to see if it is an enemy or player and run a differen animation
           // Destroy(character);
            //respawn
            //character.transform.position = new Vector3(0,0,0);
            health = startHealth;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        //if the player stays within range of the enemy the player will take damage every couple seconds
        if (other.gameObject.tag == "enemy")//enemyWeapon
        {
            Debug.Log("hit");
            if (timer > 0 )//(timer <= 1)
            {
                timer -= Time.deltaTime;
             //StartCoroutine(CoolDown());
            }
            else if (timer < 0 )
            {
                weapon = other.gameObject;
                damageTaken = weapon.gameObject.GetComponentInParent<BasicEnemyBehavior>().damage;
                health -= damageTaken;
                timer = reset;
            }
        }
    }

    IEnumerator CoolDown()
    {
        while (timer > 0)
        {
            timer -= 1;
            yield return null;
        }

    }
}
