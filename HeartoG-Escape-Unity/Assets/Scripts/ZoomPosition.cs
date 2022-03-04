/**** 
 * Created by: Ava Fritts
 * Date Created: Feb 28, 2022
 * 
 * Last Edited by: NA
 * Last Edited: Feb 28, 2022
 * 
 * Description: The script for each zoom in... Probably never needed this to begin with.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomPosition : MonoBehaviour
{
    [Header("Set in Inspector?")]
    //public GameObject theObject;
    public float fOV; //target field of View.
   
    /**Variables**/
    [Header("Set dynamically")]
    //public bool canGet; It turns out that this Boolean is never needed in the first place.
    public GameObject theObject;
    Vector3 evPos;

    // Start is called before the first frame update
    void Start()
    {
        //Vector3 evPos = this.GetComponent<Transform>;
    }

    public void OnMouseEnter()
    {
        print("Mouse found " + theObject); //checking to see that the mouse can click it.
    }
    public void OnMouseExit()
    {
        print("Mouse left " + theObject);
 
    }

    // Update is called once per frame
    /**  void FixedUpdate()
      {
          if (POI == null) return;
          Vector3 destination = POI.transform.position;

          transform.position = destination;
      }**/

    public void OnMouseDown()
    {
        //if (canGet == true)
        //{
            print(theObject.transform.position);
            //CameraNavigation.eFOV = fOV;
            CameraNavigation.POI = theObject;
        Camera.main.fieldOfView = fOV;

        //}
    }
}
