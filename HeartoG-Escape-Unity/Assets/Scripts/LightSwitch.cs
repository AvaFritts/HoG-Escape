/**** 
 * Created by: Ava Fritts
 * Date Created: March 7, 2022
 * 
 * Last Edited by: NA
 * Last Edited: March 7, 2022
 * 
 * Description: The system that controls the lights dynamics.
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    /**Variables**/

    [Header("Set in Inspector")]
    [Tooltip("The lights currently in the scene")]
    public GameObject[] standardLights; //the "normal" lights
    public GameObject[] uVLights; //the "UV" lights
    [Space(10)]

    [Tooltip("Turn this on if the UV lights should be active from the start")]
    public bool tutorialLevel;
    [Space(10)]

    [Header("Set Dynamically")]
    public bool lightOn;

    // Start is called before the first frame update
    void Start()
    {
        lightOn = true;
        if (tutorialLevel)
        {
            GameManager.GM.UVLightsON = true; //if the current level starts with the UV lights active, turn this variable on
        }
    }

    void OnMouseDown()
    {
        if (lightOn)
        {
            TurnLightsOff();
        }
        else
        {
            TurnLightsOn();
        } }

    public void TurnLightsOff()
    {
        foreach (GameObject targetLight in standardLights)
        {
            targetLight.SetActive(false); //turning off the normal lights
        }
        if (GameManager.GM.UVLightsON)
        {
            foreach (GameObject targetLight in uVLights)
            {
                targetLight.SetActive(true); //turning on the uv lights
            }
        }

        lightOn = false;

    }

    public void TurnLightsOn()
    {
        foreach (GameObject targetLight in standardLights)
        {
            targetLight.SetActive(true); //turning on the normal lights
        }
        if (GameManager.GM.UVLightsON) //if the game has reached a point where the UV lights should be active
        {
            foreach (GameObject targetLight in uVLights)
            {
                targetLight.SetActive(false); //turning off the UV lights
            }
        }

        lightOn = true;

    }

}
