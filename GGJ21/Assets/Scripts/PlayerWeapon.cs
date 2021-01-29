using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    [NonSerialized] public Item weapon;
    private ItemManagement items;
    public float damage;
    public float range;
    public BoxCollider box;
    private GameObject enemy;
    private bool hit;
    int currentWeapon;
    private BoxCollider weaponStats;
    private float nr;
    // Start is called before the first frame update
    void Start()
    {
        hit = box.GetComponent<BoxCollider>().enabled;
        hit = false;
        weapon = items.items[0];
        currentWeapon = 0;
        weaponStats = box.GetComponent<BoxCollider>();
        nr = weaponStats.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //set the stats to the current weapon
        damage = weapon.stats["Damage"];
        range = weapon.stats["Range"];
        //if the player presses the left mouse click 
        //swing the weapon
        if (Input.GetButton("Fire1"))
        {
            //play animation and activate damage
            hit = true;
        }
        else
        {
            hit = false;
        }

        //if check so the player can switch between available weapons
        //if nothing is in that slot it gets defaulted to fists
        if (Input.GetButton("next"))
        {
            weapon = items.items[currentWeapon + 1]; 
        }
        else if (Input.GetButton("previous"))
        {
            weapon = items.items[currentWeapon - 1];
        }
        //if there is no next or previous weapon the next equal 0 and previous equals 3

        //adjust the range and damage of the weapon hit box
        nr = range;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //deal damage to the enemy
        if (collision.gameObject.tag == "enemy" && hit == true)
        {
            enemy = collision.gameObject;
            enemy.gameObject.GetComponent<BasicEnemyBehavior>().health -= (int)damage;
        }

    }
}
