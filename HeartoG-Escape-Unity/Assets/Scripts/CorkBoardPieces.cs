using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorkBoardPieces : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject startingSprite;
    public GameObject endingSprite;
    public InventoryCanvas currentItemGetter; //only used if it needs an item.
    [Tooltip("This shows the inventory button and ID to remove if an item is needed")]
    public int keyIDNum; //number of the inventory item required to unlock it.
    public string reqKey; //the name of the item needed to unlock this door, if needed to be unlocked.
    [Space(10)]

    public bool uVTrigger; //if used for the UV lights

    public bool isUnlocked; //is it in its "broken" state?
    // Start is called before the first frame update
    void Start()
    {
        currentItemGetter = GameObject.FindObjectOfType<InventoryCanvas>();
        endingSprite.SetActive(false);
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (isUnlocked != true) //if the item is in its base state, check to see the item
        {
            if (currentItemGetter.tag == reqKey)
            {
                isUnlocked = true;
                //physicalLock.SetActive(false);
                currentItemGetter.RemoveItem(keyIDNum);
                startingSprite.SetActive(false);
                endingSprite.SetActive(true);

                if (uVTrigger)
                {
                    GameManager.GM.UVLightsON = true;
                }
                    }
        }
    }
}
