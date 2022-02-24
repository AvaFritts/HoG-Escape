using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraNavigation : MonoBehaviour
{
    /**VARIABLES**/
    [Header("Set in Inspector")]
    public float rotat = 0; //current rotation of the system
    //Vector3 rot = new Vector3(0, 0, 0);
    //GameObject myCam ;


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
        //Vector3 rot = new Vector3(0, rotat, 0);
        //Quaternion rotation = Quaternion.Euler(rot);

        //myCam = 
        if (rotat < -270 || rotat > 270) //just so I don't have to worry about extreme values.
        {
            rotat = 0;
        }
    }

    // Update is called once per frame
    public void OnLeftClick()
    {
        this.transform.Rotate(0, -90, 0);  
    }

    public void OnRightClick()
    {
        this.transform.Rotate(0, 90, 0); //rotat + 90;
    }

    /**private void FixedUpdate()
    {
        if (rotat < -270 || rotat > 270) //just so I don't have to worry about extreme values.
        {
            rotat = 0;
            this.transform.Rotate(0, rotat, 0);
        }
    }**/

}
