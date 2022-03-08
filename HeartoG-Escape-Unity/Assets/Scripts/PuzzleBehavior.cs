/**** 
 * Created by: Ava Fritts
 * Date Created: March 3, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 7, 2022
 * 
 * Description: The system that controls the main puzzle dynamics.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBehavior : MonoBehaviour
{

    /**VARIABLES**/
    public GameObject lockedObj;

    public GameObject submitButton;
    public GameObject[] puzzleButtons;

    private Renderer mr; //for changing color;

    public string currentID;
    public string targetSolution; //the string

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<Renderer>();
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
            if (gameObject.transform.parent.tag.Equals("C")) //if this is the door for the courage ending
            {
                lockedObj.GetComponent<Lock>().Unlock();
            }
            else
            {
                gameObject.transform.parent.transform.parent.GetComponent<Lock>().Unlock();
                mr.material.color = new Color(0f, 1f, 0f, 1f);
            }
        }
        currentID = null;
    }
}
