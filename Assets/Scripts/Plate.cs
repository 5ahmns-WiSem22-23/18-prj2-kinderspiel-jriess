using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plate : MonoBehaviour
{
    SpriteRenderer srPlate;

    public Sprite blueSprite;
    public Sprite greenSprite;
    public Sprite orangeSprite;
    public Sprite redSprite;

    public enum color
    {
        blue,
        green,
        orange,
        red
    }

    public color plateColor;

    private void Start()
    {
        srPlate = GetComponent<SpriteRenderer>();
        SetColor();
    }

    void SetColor()
    {
        if(plateColor == color.blue)
        {
            srPlate.sprite = blueSprite;
        }
        else if(plateColor == color.green)
        {
            srPlate.sprite = greenSprite;
        }
        else if (plateColor == color.orange)
        {
            srPlate.sprite = orangeSprite;
        }
        else if(plateColor == color.orange)
        {
            srPlate.sprite = redSprite;
        }
    }
}
