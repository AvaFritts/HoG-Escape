/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 18, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 3, 2022
 * 
 * Description: The system that controlls the room camera.
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
    //public GameObject myCam; //The event camera
    //public GameObject mainCam; //The Main Camera
    public GameObject home;
    public Vector3 homePos; //= (4.05, 0.6, 0);

    [Space(10)]
    [Tooltip("The walls of the current room")]
    public GameObject wall1;
    public GameObject wall2;
    public GameObject wall3;
    public GameObject wall4;

    [Space(10)]
    [Tooltip("The Button associated with turning Left")]
    public GameObject leftButton;
    [Tooltip("The Button associated with turning Right")]
    public GameObject rightButton;
    [Tooltip("The Button associated with Zooming Out")]
    public GameObject downButton;

    [Header("set Dynamically")]
    public int i;



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
        //myCam.SetActive(false);
        downButton.SetActive(false);
        i = 1;
        DisableWall();
    }

    // Update is called once per frame
    public void OnLeftClick()
    {
        this.transform.Rotate(0, -90, 0);  //rotating at a -90.
        if (i + 1 > 4) { i = 1; } //prevents case from going out of bounds
        else { i += 1; }  
        DisableWall();

    }

    public void OnRightClick()
    {
        this.transform.Rotate(0, 90, 0); //rotat + 90;
        if (i - 1 <= 0) { i = 4; } //prevents case from going out of bounds
        else { i -= 1; }
        DisableWall();
    }

    public void OnDownClick()
    {
        //Go back to previous main view.
        POI = null; //If this line isn't here, the camera will keep swapping back to the last zoom.
                    //mainCam.SetActive(true);
                    //myCam.SetActive(false);
        Camera.main.transform.position = home.transform.position;
        Camera.main.transform.rotation = home.transform.rotation;
        Camera.main.fieldOfView = 27;
        //Change the UI accordingly
        rightButton.SetActive(true);
        leftButton.SetActive(true);
        downButton.SetActive(false); //the button is not needed when the camera is zoomed out.

    }

    public void FixedUpdate()
    {
        if (POI == null) return;
        //Swap the camera to the zoom-in camera
        //mainCam.SetActive(false);
        //myCam.SetActive(true);

        //move the Zoom-in Camera to the desired position
        Vector3 destination = POI.transform.position; 
        Camera.main.transform.position = destination;
        Camera.main.transform.rotation = POI.transform.rotation;

        //Activate the correct UI buttons
        rightButton.SetActive(false);
        leftButton.SetActive(false);
        downButton.SetActive(true);
    }

    //This script is responsible for making sure nobody clicks on an "event" that the camera cannot see in its FOV
    public void DisableWall()
    {
        print(i); //shows what case it is for debugging purposes.
        switch (i)
        {
            
            case (1):
                wall1.SetActive(false);
                wall2.SetActive(true);
                wall4.SetActive(true);
                break;
            case (2):
                wall2.SetActive(false);
                wall1.SetActive(true);
                wall3.SetActive(true);
                break;
            case (3):
                wall3.SetActive(false);
                wall4.SetActive(true);
                wall2.SetActive(true);
                break;
            default:
                wall4.SetActive(false);
                wall1.SetActive(true);
                wall3.SetActive(true);
                break;
        }
    }
}
