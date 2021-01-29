using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    public float speed = 5F;
    public float gravity = 20F;
    //stats
    //public float health = 50F;
    public float stamina = 5F;
   // public GameObject weapon;
    private float refillStam;
    private bool tired = false;
    private bool cooldown = false;
    public float timer;
    private float resetTimer;
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;
    
    // Start is called before the first frame update
    void Start()
    {
        resetTimer = timer;
        refillStam = stamina;
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            //float delta = Input.GetAxis("Mouse ScrollWheel");
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            //Player is able to run in short burst - drains stamina
            
            if (Input.GetButton("Run") && stamina > 0 && tired == false && cooldown == false)
            {
                speed = 10F;
                stamina -= Time.deltaTime;
            }
            else
            {
                speed = 5F;
                tired = true;
            }

            if (stamina < refillStam && tired == true)
            {
                stamina += Time.deltaTime;
            }
            else
            {
                tired = false;
                timer = resetTimer;
            }

            if(timer <= 1 && tired == true)
            {
                StartCoroutine(CoolDown());
                cooldown = true;
            }
            else
            {
                cooldown = false;
            }

        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

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
