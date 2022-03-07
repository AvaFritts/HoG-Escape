/**** 
 * Created by: Ava Fritts
 * Date Created: March 6, 2022
 * Last Edited: March 6, 2022
 * 
 * Description: Determines how the boxes function
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedBox : Lock
{
    [Header("Set in Inspector")]
    public GameObject thisDrawer;
    //public Vector3 hello;
    public bool open;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void OnMouseDown()
    {

        if (isUnlocked != true) //if the item is locked, check to see if it needs an item
        {
            if (needsItem) { UnlockItem(); }
        }
        else
        {
            if (!open)
            {
                thisDrawer.transform.localPosition = new Vector3(thisDrawer.transform.localPosition.x, thisDrawer.transform.localPosition.y + .125f, thisDrawer.transform.localPosition.z);
                open = true;
            }
            //this.transform.Rotate(0, 60, 0);//Instead, I should put a force onto this item to slowly open it. 
        }
    }
}
