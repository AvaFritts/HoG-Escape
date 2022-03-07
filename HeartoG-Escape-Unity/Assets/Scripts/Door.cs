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

public class Door : Lock
{
    [Tooltip("Will opening this door reach an ending?")]
    public bool endDoor;

    [Header("Set Dynamically")]
    float yRotation;


    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
        yRotation = 1;
    }

    public void OnMouseEnter()
    {
        print("Mouse found Door");
    }

    /**private void FixedUpdate()
    {
        if (isUnlocked && yRotation < 45)
        {
            yRotation = yRotation*Time.deltaTime;
            this.transform.Rotate(0, yRotation, 0);
        }
    }**/

    // Update is called once per frame
    void OnMouseDown()
    {
         
        if (isUnlocked != true)
        {
            if (needsItem) { UnlockItem(); }
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

    void GameEnd()
    {
        if (this.tag.Equals("C"))
        {
            GameManager.GM.playerWon = true;
            GameManager.GM.SetPathC();//this affects the end message. This is the courage Path.

        }
        GameManager.GM.nextLevel = true;
    }
}
