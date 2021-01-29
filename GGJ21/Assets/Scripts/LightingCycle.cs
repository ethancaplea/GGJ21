using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingCycle : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // make the sun and moon orbit the world
        transform.RotateAround(Vector3.zero, Vector3.right, 10f * Time.deltaTime);
        transform.LookAt(Vector3.zero);
    }
}