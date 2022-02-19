using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraNavigation : MonoBehaviour
{
    /**VARIABLES**/
    [Header("Set in Inspector")]
    int rotat = 0; //current rotation of the system


    //The idea: Whenever one of the two buttons are pressed, the camera rotates to show another part of the room.
    //Any object not on the selected wall gets hidden

    //A second camera will be used to help with the zoom-ins.

    //The forseen problem is the inventory. UI is only on one view. There are 3 ways to solve this:
     //1: The UI is duplicated on each screen. This is going to be complicated and require a LOT of debugging.
     //2: Have the UI for the Inventory change with each screen. Could work... Idk.
     //3: Two cameras on the UI? Maybe.

    // Start is called before the first frame update
    void Start()
    {
        if (rotat < -270 || rotat > 270) //just so I don't have to worry about extreme values.
        {
            rotat = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //On a left button click, either activate the next camera in line or  
    
}
