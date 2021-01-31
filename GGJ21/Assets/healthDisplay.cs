using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script changes the healthBar UI when the player takes damage
/// </summary>

public class healthDisplay : MonoBehaviour
{
    GameObject player;   // the player
    float playerHealth;  // the player's health
    Image image;         // the image to display in ui
    Sprite sprite;       // the sprite of the image
    public Sprite[] sprites;    // array of healthBar sprites

    // Start is called before the first frame update
    void Start()
    {
        // get player GameObject
        player = GameObject.Find("player");
        // get sprite component
        image = GetComponent<Image>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // keep playerHealth updated at all times
        playerHealth = player.GetComponent<PlayerHealth>().health;

        // change health display when player health changes
        #region health values

        if (playerHealth == 10)
        {
            image.sprite = sprites[9];
        }
        if (playerHealth == 9)
        {
            image.sprite = sprites[8];
        }
        if (playerHealth == 8)
        {
            image.sprite = sprites[7];
        }
        if (playerHealth == 7)
        {
            image.sprite = sprites[6];
        }
        if (playerHealth == 6)
        {
            image.sprite = sprites[5];
        }
        if (playerHealth == 5)
        {
            image.sprite = sprites[4];
        }
        if (playerHealth == 4)
        {
            image.sprite = sprites[3];
        }
        if (playerHealth == 3)
        {
            image.sprite = sprites[2];
        }
        if (playerHealth == 2)
        {
            image.sprite = sprites[1];
        }
        if (playerHealth == 1)
        {
            image.sprite = sprites[0];
        }

        #endregion
    }
}
