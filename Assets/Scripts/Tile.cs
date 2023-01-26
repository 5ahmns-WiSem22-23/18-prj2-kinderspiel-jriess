using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    public bool tileOccupied;

    public Sprite emptySprite;
    public Sprite occupiedSprite;

    public enum color
    {
        blue,
        green,
        orange,
        red
    }

    public color tileColor;

    SpriteRenderer srTiles;

    private void Start()
    {
        srTiles = GetComponent<SpriteRenderer>();
        ResetTile();
    }

    private void Update()
    {
        SetColor();
    }

    void ResetTile()
    {
        tileOccupied = false;       
    }

    void SetColor()
    {
        if (!tileOccupied)
        {
            srTiles.sprite = emptySprite;
        }
        else if(tileOccupied)
        {
            srTiles.sprite = occupiedSprite;
        }
    }

    public void SetToOccupied()
    {
        tileOccupied = true;
        FindObjectOfType<SpawnManager>().readyToSpawn = true;
    } 
}
