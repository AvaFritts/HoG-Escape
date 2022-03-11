/**** 
 * Created by: Ava Fritts
 * Date Created: March 3, 2022
 * 
 * Last Edited: March 8, 2022
 * 
 * Description: The system that controls the main puzzle dynamics.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleBehavior : MonoBehaviour
{

    /**VARIABLES**/
    [Header("Set in Inspector")]
    public GameObject lockedObj;

    public GameObject submitButton;
    public GameObject[] puzzleButtons;

    private Renderer currentColor; //for changing color;

    [Space(10)]
    public string targetSolution; //the string
    [Header("Set Dynamically")]
    public string currentID; //the answer the player submitted.

    // Start is called before the first frame update
    void Start()
    {
        currentColor = GetComponent<Renderer>();
    }

    // Update is called once per frame
    public void OnMouseDown()
    {
        print("Submitting thing");
       foreach(GameObject targetButton in puzzleButtons)
        {
            currentID += targetButton.GetComponent<PuzzleSprites>().currentValue.ToString(); //making a string out of each puzzle piece.
        }
        //print(currentID);
        if (currentID.Equals(targetSolution)){
            if (gameObject.transform.parent.tag.Equals("C")) //if this is the door for the courage ending
            {
                lockedObj.GetComponent<Lock>().Unlock();
                currentColor.material.color = new Color(0f, 1f, 0f, 1f); //Changes the color of the button to green
            }
            else
            {
                gameObject.transform.parent.transform.parent.GetComponent<Lock>().Unlock(); //unlocks the door
                currentColor.material.color = new Color(0f, 1f, 0f, 1f); //changes the color of the button to green
            }
        }
        currentID = null;
    }
}
