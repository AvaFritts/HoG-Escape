/**** 
 * Created by: Ava Fritts
 * Date Created: March 7, 2022
 * Last Edited: March 7, 2022
 * 
 * Description: The code that dictates all of the hidden symbols for the game.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVLights : MonoBehaviour
{
    public GameObject hiddenNumber;
    public GameObject theLightSwitch;

    // Start is called before the first frame update
    void Start()
    {
        hiddenNumber.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (!theLightSwitch.GetComponent<LightSwitch>().lightOn && GameManager.GM.UVLightsON)
        {
            hiddenNumber.SetActive(true);
        }
    }

    private void OnMouseExit()
    {
        hiddenNumber.SetActive(false);
    }
}
