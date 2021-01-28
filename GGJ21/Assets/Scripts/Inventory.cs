using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> Backpack = new List<Item>();
    public ItemManagement items;

    public void AddItem(int id)
    {
        Item item = items.GetItem(id);
        Backpack.Add(item);
    }
}
