using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManagement : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    void Management()
    {
        items = new List<Item>()
        {
            new Item(0, "Axe", "Very long", new Dictionary<string, float>
            {
                {"Range", 3.0f},
                {"Damage", 2.0f }

            }, "Weapon"),
            new Item(1, "Sword", "Very strong", new Dictionary<string, float>
            {
                {"Range", 1},
                {"Damage", 5}
            }, "Weapon"),
            new Item(2, "Boots", "Very fast", new Dictionary<string, float>
            {
                {"Speed", 3 }
            }, "Power up")
        };
    }
}
