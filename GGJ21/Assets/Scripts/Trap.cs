using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            other.gameObject.GetComponent<BasicEnemyBehavior>().trapFlag = true;
            Debug.Log("Trap active");
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Trap active");
        }
    }
}
