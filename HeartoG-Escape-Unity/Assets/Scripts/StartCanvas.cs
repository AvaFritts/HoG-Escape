using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StartCanvas : MonoBehaviour
{
    /**Variables**/
    GameManager gm; //ref to game manager

    [Header("Canvas Settings")]
    public Text titleTextBox;
    public Text creditsTextBox;
    public Text copyTextBox;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameManager.GM;

        titleTextBox.text = gm.gameTitle;
        creditsTextBox.text = gm.gameCredits;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
