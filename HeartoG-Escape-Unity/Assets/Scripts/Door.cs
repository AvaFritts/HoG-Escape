using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [Header("set in Inspector?")]
    public bool unlocked;


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
            if (this.tag.Equals("C"))
            {
                GameManager.GM.playerWon = true;
   
            }
            //GameManager.GM.GameOver();
            Invoke("GameEnd", 3);
           
        }
    }

    void GameEnd()
    {
        GameManager.GM.nextLevel = true;
    }
}
