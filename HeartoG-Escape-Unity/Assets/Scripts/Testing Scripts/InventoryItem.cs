using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItem
{
    public InventoryItemData data { get; private set; }
    public int stackSize { get; private set; }
    public InventoryItem(InventoryItemData source)
    {
        data = source;
        AddToStack();
    }

    // Update is called once per frame
    public void AddToStack()
    {
        stackSize++;
    }
    public void RemoveFromStack()
    {
        stackSize--;
    }
}
