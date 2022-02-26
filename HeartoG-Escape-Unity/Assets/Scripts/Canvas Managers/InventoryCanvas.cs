/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 26, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 26, 2022
 * 
 * Description: Script for the inventory system.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components

public class InventoryCanvas : MonoBehaviour
{
    /** Variables**/
    [Header("Edit in Here")]
    public string idTag;
    //public GameObject ivButton;

    [Header("Edit dynamically")]
    public GameObject[] numItems;
    
    // Start is called before the first frame update
    void Start()
    {
        numItems = GameObject.FindGameObjectsWithTag(idTag);
       // foreach (GameObject consume in numItems){
         //   Instantiate<GameObject>(ivButton);
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddToInventory(GameObject itemHere)
    {
        //checks each button in order. If the button is full, it skips it. if the button is NOT null, it gives the item's 
        //value to the button and stops the search. it will then swap the button's sprite for 

        //The exception is for the Poem pieces.
    }

    public void RemoveItem()
    {
       
    }
}
