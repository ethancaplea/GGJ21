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

    public void AddItem(string name)
    {
        Item item = items.GetItem(name);
        Backpack.Add(item);
    }
    public void removeItem(int id)
    {
        Item removeItem = Backpack.Find(item => item.id == id);
        if (removeItem != null)
        {
            Backpack.Remove(removeItem);
        }
    }
    public void removeItem(string name)
    {
        Item removeItem = Backpack.Find(item => item.title == name);
        if (removeItem != null)
        {
            Backpack.Remove(removeItem);
        }
    }
}
