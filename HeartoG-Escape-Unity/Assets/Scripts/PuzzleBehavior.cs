/**** 
 * Created by: Ava Fritts
 * Date Created: March 3, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 6, 2022
 * 
 * Description: The system that controls the main puzzle dynamics.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBehavior : MonoBehaviour
{
    public GameObject lockedObj;

    public GameObject submitButton;
    public GameObject[] puzzleButtons;
    //public Sprite[] buttonSprites1;
    //public S

    public string currentID;
    public string targetSolution; //the string

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        print("Submitting thing");
       foreach(GameObject targetButton in puzzleButtons)
        {
            currentID += targetButton.GetComponent<PuzzleSprites>().currentValue.ToString(); //making the 
        }
        print(currentID);
        if (currentID.Equals(targetSolution)){
            //newLock = lockedObj.GetComponent<Lock>();
                gameObject.transform.parent.transform.parent.GetComponent<Lock>().Unlock();
        }
        currentID = null;
    }
}
