using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public float damage;
    public float range;
    private float nr;
   // public float fireRate;
   // public float knockback;
    private GameObject enemy;
    [NonSerialized] public PlayerWeapon currentWeapon;
    private bool hit;
    // Start is called before the first frame update
    void Start()
    {
        currentWeapon = this.GetComponent<PlayerWeapon>();
        hit = this.GetComponent<BoxCollider>().enabled;
        hit = false;

       nr = this.GetComponent<BoxCollider>().size.x;
    }

    // Update is called once per frame
    void Update()
    {
        //set the stats to the current weapon
        damage = currentWeapon.GetComponent<PlayerWeapon>().damage;
        range = currentWeapon.GetComponent<PlayerWeapon>().range;
        nr = range;
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
