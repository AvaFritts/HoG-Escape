/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 26, 2022
 * 
 * Last Edited: March 3, 2022
 * 
 * Description: This script manages the doors, which are the win/loose conditions of the game.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("set in Inspector?")]
    public bool isUnlocked;
    public InventoryCanvas currentItemGetter;
    public int keyIDNum; //number of the inventory item required to unlock it.
    public string reqKey; //the name of the item needed to unlock this door, if needed to be unlocked.
    [Tooltip("Will opening this door reach an ending?")]
    public bool endDoor;


    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
    }

    public void OnMouseEnter()
    {
        print("Mouse found Door");
    }
        // Update is called once per frame
        void OnMouseDown()
    {
         
        if (isUnlocked != true)
        {
            Unlock();
        }
            else
        {
            this.transform.Rotate(0, 45, 0);//Instead, I should put a force onto this item to slowly open it. 
            //GameManager.GM.GameOver();
            if(endDoor == true) {
            Invoke("GameEnd", 2);
            }

        }
    }

    public void Unlock()
    {
        if (currentItemGetter.tag == reqKey)
        {
            isUnlocked = true;
            currentItemGetter.RemoveItem(keyIDNum);
        }

    }

    void GameEnd()
    {
        if (this.tag.Equals("C"))
        {
            GameManager.GM.playerWon = true;
            GameManager.GM.SetPathC();//this affects the 

        }
        GameManager.GM.nextLevel = true;
    }
}
