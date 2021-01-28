using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public string title;
    public string description;
    public Sprite logo;
    public Dictionary<string, float> stats = new Dictionary<string, float>();
    public string tag;

    public Item(int id, string title, string description, Dictionary<string, float> stats, string tag)
    {
        this.id = id;
        this.title = title;
        this.description = description;
        this.stats = stats;
        this.logo = Resources.Load<Sprite>("Sprites/" + title);
        this.tag = tag;
    }

    public Item(Item item)
    {
        this.id = item.id;
        this.title = item.title;
        this.description = item.description;
        this.stats = item.stats;
        this.logo = Resources.Load<Sprite>("Sprites/" + item.title);
        this.tag = item.tag;
    }
}
