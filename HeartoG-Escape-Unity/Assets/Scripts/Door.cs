using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("set in Inspector?")]
    public bool unlocked;
    [Tooltip("Will opening this door reach an ending?")]
    public bool endDoor;


    // Start is called before the first frame update
    void Start()
    {
        //GameObject helpMe = GameObject.Find("_GameManager");
    }

    public void OnMouseEnter()
    {
        print("Mouse found Door");
    }
        // Update is called once per frame
        void OnMouseDown()
    {
         
        if (unlocked == true)
        {
            this.transform.Rotate(0, 45, 0);//Instead, I should put a force onto this item to slowly open it. 
            //GameManager.GM.GameOver();
            if(endDoor == true) {
            Invoke("GameEnd", 3);
            }

        }
    }

    void GameEnd()
    {
        if (this.tag.Equals("C"))
        {
            GameManager.GM.playerWon = true;

        }
        GameManager.GM.nextLevel = true;
    }
}
