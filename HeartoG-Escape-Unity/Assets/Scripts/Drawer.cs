/**** 
 * Created by: Ava Fritts
 * Date Created: March 6, 2022
 * Last Edited: March 6, 2022
 * 
 * Description: Determines how the drawers function
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : Lock
{
    [Header("Set in Inspector")]
    public GameObject thisDrawer;
    //public Vector3 hello;
    public bool open;

    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (needsItem)
        {
            UnlockItem();
        } 
        else if (isUnlocked)
        {
            if (!open)
            {
                thisDrawer.transform.localPosition = new Vector3(thisDrawer.transform.localPosition.x - .25f, thisDrawer.transform.localPosition.y, thisDrawer.transform.localPosition.z);
                open = true;
            }
            else
            {
                //transform the other way.
                thisDrawer.transform.localPosition = new Vector3(thisDrawer.transform.localPosition.x + .25f, thisDrawer.transform.localPosition.y, thisDrawer.transform.localPosition.z);
                open = false;
            }
        }
    } //end OnMouseDown

}
