using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public GameObject character;
    public float health;
    private GameObject weapon;//need to be looking at the monsters damage/weapon
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the health falls below 0 character dies
        if(health < 0)
        {
            //if check to see if it is an enemy or player and run a differen animation
            Destroy(character);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemyWeapon")
        {
            weapon = collision.gameObject;
            //health -= weapon.damage;
        }
    }
}
