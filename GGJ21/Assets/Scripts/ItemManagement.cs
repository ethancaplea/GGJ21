using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement : MonoBehaviour
{
    public List<Item> items = new List<Item>();


    public void Start()
    {
        Management();
    }
    public Item GetItem(int id)
    {
        return items.Find(item => item.id == id);
    }
    public Item GetItem(string name)
    {
        return items.Find(item => item.title == name);
    }
    void Management()
    {
        items = new List<Item>()
        {
            new Item(0, "Hands", "Weak", new Dictionary<string, float>
            {
                {"Range", 1.0f},
                {"Damage", 1.0f }

            }, "Weapon"),
            new Item(1, "Sword", "Very strong", new Dictionary<string, float>
            {
                {"Range", 1},
                {"Damage", 5}
            }, "Weapon"),
            new Item(2, "Boots", "Very fast", new Dictionary<string, float>
            {
                {"Speed", 3 }
            }, "Power up"),

            new Item(3, "Tower Part", "N/A", new Dictionary<string, float>
            {}, "Component"),
        };

        
        
    }
}
