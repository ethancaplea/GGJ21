using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerbody;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //The camera needs to target the player position, The camera normal (standing) position
        this.transform.position = new Vector3(playerbody.position.x, playerbody.position.y + 20, playerbody.position.z);
    }
}
