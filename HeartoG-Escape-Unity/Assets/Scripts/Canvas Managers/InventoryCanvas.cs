/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 26, 2022
 * 
 * Last Edited: March 2, 2022
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
    public int idTag;
    //public GameObject ivButton;

    [Header("Edit dynamically")]
    public GameObject[] numItemsArray; //The array of inventory Buttons
    public int numItemsIDList;

    private void Awake()
    {
        //deactivate every single inventory button
        foreach (GameObject ivButton in numItemsArray)
        {
            numItemsIDList++;
            ivButton.SetActive(false);
        }
    }

    public void AddToInventory(int testValue)
    {
        for (int i = 0; i < numItemsIDList; i++)
        {
            if (testValue == i) //if the array finds the correct number
            {
                numItemsArray[i].SetActive(true);//activate the button I need
            }
        }
    }
}
