/**** 
 * Created by: Ava Fritts
 * Date Created: March 6, 2022
 * Last Edited: March 7, 2022
 * 
 * Description: The code that dictates all locked objects.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    [Header("set in Inspector")]
    public bool isUnlocked;
    public bool needsItem;
    public GameObject physicalLock; //If there is a physical lock showing the player that this item is locked.
    [Space(10)]
    public InventoryCanvas currentItemGetter; //only used if it needs an item.
    [Tooltip("This shows the inventory button and ID to remove if an item is needed")]
    public int keyIDNum; //number of the inventory item required to unlock it.
    public string reqKey; //the name of the item needed to unlock this door, if needed to be unlocked.
    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
    }

    // Update is called once per frame
    public void UnlockItem() //Used only if an item is needed;
    {
        if(currentItemGetter.tag == reqKey)
        {
            isUnlocked = true;
            //physicalLock.SetActive(false);
            Destroy(physicalLock); //The physical lock is now gone;
            currentItemGetter.RemoveItem(keyIDNum);
        }

    }

    public void Unlock() //standard puzzle unlock
    {  
        isUnlocked = true;
    }
}
