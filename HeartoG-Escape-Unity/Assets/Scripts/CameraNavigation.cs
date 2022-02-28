/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 18, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 26, 2022
 * 
 * Description: The system that controlls the two room cameras
****/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraNavigation : MonoBehaviour
{
    /**VARIABLES**/
    static public GameObject POI;


    [Header("Set in Inspector")]
    [Tooltip("The cameras used for zoom-ins and normal viewing")]
    public GameObject myCam; //The event camera
    public GameObject mainCam; //The Main Camera
    public Vector3 homePos; //= (4.05, 0.6, 0);
    [Space(10)]
    [Tooltip("The Button associated with turning left")]
    public GameObject leftButton;
    public GameObject rightButton;
    public GameObject downButton;



    //The idea: Whenever one of the two buttons are pressed, the camera rotates to show another part of the room.
    //Any object not on the selected wall gets hidden

    //A second camera will be used to help with the zoom-ins.
    //It might be nice to throw away the need for a second script and to check for tags instead... but I doubt I could do that so easily.

    //The forseen problem is the inventory. UI is only on one view. There are 3 ways to solve this:
    //1: The UI is duplicated on each screen. This is going to be complicated and require a LOT of debugging.
    //2: Have the UI for the Inventory change with each screen. Could work... Idk.
    //3: Two cameras on the UI? Maybe.

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 rot = new Vector3(0, rotat, 0);
        //Quaternion rotation = Quaternion.Euler(rot);

        myCam.SetActive(false);
        downButton.SetActive(false);
        
    }

    // Update is called once per frame
    public void OnLeftClick()
    {
        this.transform.Rotate(0, -90, 0);  //rotating at a -90.
    }

    public void OnRightClick()
    {
        this.transform.Rotate(0, 90, 0); //rotat + 90;
    }

    public void OnDownClick()
    {
        //Go back to previous main view.
        POI = null; //If this line isn't here, the camera will keep swapping back to the last zoom.
        mainCam.SetActive(true);
        myCam.SetActive(false);
        //Change the UI accordingly
        rightButton.SetActive(true);
        leftButton.SetActive(true);
        downButton.SetActive(false); //the button is not needed when the camera is zoomed out.

    }

    public void FixedUpdate()
    {
        if (POI == null) return;
        //Swap the camera to the zoom-in camera
        mainCam.SetActive(false);
        myCam.SetActive(true);

        //move the Zoom-in Camera to the desired position
        Vector3 destination = POI.transform.position; 
        myCam.transform.position = destination;
        myCam.transform.rotation = POI.transform.rotation;

        //Activate the correct UI buttons
        rightButton.SetActive(false);
        leftButton.SetActive(false);
        downButton.SetActive(true);
    }

}
