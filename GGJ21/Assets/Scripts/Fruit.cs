using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
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
            other.gameObject.GetComponent<BasicEnemyBehavior>().fruitFlag = true;
            Debug.Log("Fruit active");
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player Fruit active");
        }
    }
}
