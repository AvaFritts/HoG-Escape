/**** 
 * Created by: Ava Fritts
 * Date Created: March 6, 2022
 *
 * Last Edited: March 6, 2022
 * 
 * Description: Updates the buttons in the given puzzle
****/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSprites : MonoBehaviour
{
    [Header("Set in Inspector?")]
    public Sprite[] buttonSprites;

    [Header("Set dynamically")]
    SpriteRenderer spriteRenderer;
    public int currentValue;
    public int finalValue;

    // Start is called before the first frame update
    void Start()
    {
        currentValue = 0;
        spriteRenderer = this.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = buttonSprites[0];
        finalValue = buttonSprites.Length;
    }

    public void OnMouseEnter()
    {
        print("Mouse found this button!");
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        currentValue += 1;
        if(currentValue >= finalValue)
        {
            //change sprite to 1st sprite
            currentValue = 0;
            spriteRenderer.sprite = buttonSprites[0];
        }
        else
        {
            spriteRenderer.sprite = buttonSprites[currentValue];
        }



    }
}
