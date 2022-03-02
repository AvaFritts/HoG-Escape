/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 18, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 2, 2022
 * 
 * Description: This script manages the pickup and management of items.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Consumable : MonoBehaviour
{
    /*** VARIABLES ***/
    [Header("Set in Inspector")]
    public bool canCombine;
    public int value;
    public string theCombine;
    public GameObject newLife; //the result of the combination.
    [Space(10)]

    public GameObject itemHere;
    public string itemName;
    [Space(10)]

    [Tooltip("Will the item go away after use?")]
    public bool canBreak;
    public int numUses = 1; //how many times the item can be used 

    [Header("Set Dynamically")]
    public InventoryCanvas referenceItem; //the canvas it belongs to
    public bool canGet;

    // Start is called before the first frame update
    void Start()
    {
        canGet = false;
        referenceItem = GameObject.FindObjectOfType<InventoryCanvas>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseEnter()
    {
        print("Mouse found this "+itemName);
        canGet = true;
    }
    public void OnMouseExit()
    {
        print("Mouse left this "+itemName);
        canGet = false;
    }
    void OnMouseDown()
    {
        if (canGet == true)
        {
            //InventoryCanvas.current.Add(referenceItem);
            itemHere.SetActive(false);
            referenceItem.AddToInventory(value); //checks value 
            //itemHere.transform.position.x(-175, 0, 0);
           
        }
    }
}
