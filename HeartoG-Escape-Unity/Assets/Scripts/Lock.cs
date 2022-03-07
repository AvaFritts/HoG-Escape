using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [Header("set in Inspector?")]
    public bool isUnlocked;
    public bool needsItem;
    public GameObject physicalLock;
    public InventoryCanvas currentItemGetter;
    public int keyIDNum; //number of the inventory item required to unlock it.
    public string reqKey; //the name of the item needed to unlock this door, if needed to be unlocked.
    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
    }

    // Update is called once per frame
    public void UnlockItem()
    {
        if(currentItemGetter.tag == reqKey)
        {
            isUnlocked = true;

            currentItemGetter.RemoveItem(keyIDNum);
        }

    }

    public void Unlock()
    {  
        isUnlocked = true;
    }
}
