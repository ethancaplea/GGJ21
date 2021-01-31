using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIItems : MonoBehaviour
{
    public Item item;
    public Image sprite;

    private void Start()
    {
        sprite = GetComponent<Image>();
        fillSlot(null);
    }

    public void fillSlot(Item item)
    {
        this.item = item;
        if(this.item != null)
        {
            sprite.color = Color.white;
            sprite.sprite = this.item.logo;
        }
        else
        {
            sprite.color = Color.clear;
        }
    }
}
