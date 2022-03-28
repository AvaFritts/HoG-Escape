/**** 
 * Created by: Akram Taghavi-Burrs
 * Date Created: Feb 23, 2022
 * 
 * Last Edited by: Ava Fritts
 * Last Edited: Mar 27, 2022
 * 
 * Description: Updates end canvas refencing game manger
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //libraries for UI components

public class EndCanvas : MonoBehaviour
{
    /*** VARIABLES ***/

    GameManager gm; //reference to game manager

    [Tooltip("These objects contain audio and a sprite that should be placed under the light.")]
    public GameObject objectCourage; //object that contains ending dialogue for the C ending
    public GameObject objectFear; //object that contains audio for the Fear ending


  [Header("Canvas SETTINGS")]
    public Text endMsgTextbox; //textbox for the title


    private void Start()
    {
        gm = GameManager.GM; //find the game manager

        Debug.Log(gm.endMsg);

        //Set the Canvas text from GM reference
        endMsgTextbox.text = gm.endMsg;
        
        if(gm.playerWon == true) { objectCourage.SetActive(true); } else { objectFear.SetActive(true); }

    }

    public void GameRestart()
    {
        gm.StartGame(); //refenece the StartGame method on the game manager

    }

    public void GameExit()
    {
        gm.ExitGame(); //refenece the ExitGame method on the game manager
    }

}
