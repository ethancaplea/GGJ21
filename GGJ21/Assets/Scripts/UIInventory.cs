using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public List<UIItems> itemList = new List<UIItems>();
    public GameObject itemSlot;
    public Transform inventoryPanel;
    public int invCapacity = 16;

    private void Start()
    {
        for(int i = 1; i < invCapacity; i++)
        {
            GameObject newItem = Instantiate(itemSlot);
            newItem.transform.SetParent(inventoryPanel);
            itemList.Add(newItem.GetComponentInChildren<UIItems>());
        }
    }

    public void UpdateInv(int slot, Item newItem)
    {
        itemList[slot].fillSlot(newItem);
    }
    public void AddItem(Item item)
    {
        UpdateInv(itemList.FindIndex(i => i.item == null), item);
    }
    public void RemoveItem(Item item)
    {
        UpdateInv(itemList.FindIndex(i => i.item == item), null);
    }
}
