using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransfer : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Scenes/Shed");
            Debug.Log("Poopy");
        }

    }


}
