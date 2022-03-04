/**** 
 * Created by: Ava Fritts
 * Date Created: March 3, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 3, 2022
 * 
 * Description: The system that controls the main puzzle dynamics.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBehavior : MonoBehaviour
{
    public Door lockedObj;
    public GameObject submitButton;

    public string targetSolution; //the string

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void onMouseDown()
    {
       //check to see if the code matches the win code.
       //if()
        lockedObj.Unlock();
    }
}
