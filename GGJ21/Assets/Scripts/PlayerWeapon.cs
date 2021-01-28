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
    private GameObject enemy;
    private bool hit;
    // Start is called before the first frame update
    void Start()
    {
        hit = this.GetComponent<BoxCollider>().enabled;
        hit = false;
        weapon = items.items[0];
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

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "enemy")
        {
            enemy = collision.gameObject;
        }
        //deal damage to the enemy

    }
}
