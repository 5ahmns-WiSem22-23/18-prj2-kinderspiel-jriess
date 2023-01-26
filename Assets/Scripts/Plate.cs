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

    Vector3 mousePositionOffset;

    public LayerMask layer;

    Vector3 GetMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void Update()
    {
        CheckIfPutDown();
    }

    private void OnMouseDown()
    {
        mousePositionOffset = gameObject.transform.position - GetMouseWorldPosition();
    }

    private void OnMouseDrag()
    {
        transform.position = GetMouseWorldPosition() + mousePositionOffset;
    }

    void CheckIfPutDown()
    {
        Collider2D col = Physics2D.OverlapCircle(transform.position, 0.5f, layer);
        if(col != null)
        {
            Debug.Log(col.gameObject.GetComponent<Tile>().tileColor);
            Debug.Log(plateColor);
            if(col.gameObject.GetComponent<Tile>().tileColor == plateColor && !col.gameObject.GetComponent<Tile>().tileOccupied)
            {
                Debug.Log("dodododo");
                col.gameObject.GetComponent<Tile>().SetToOccupied();
                Destroy(gameObject);
            }
        }       
    }

    public Tile.color plateColor;

    private void Start()
    {
        srPlate = GetComponent<SpriteRenderer>();
        SetColor();
    }

    void SetColor()
    {
        if(plateColor == Tile.color.blue)
        {
            srPlate.sprite = blueSprite;
        }
        else if(plateColor == Tile.color.green)
        {
            srPlate.sprite = greenSprite;
        }
        else if (plateColor == Tile.color.orange)
        {
            srPlate.sprite = orangeSprite;
        }
        else if(plateColor == Tile.color.red)
        {
            srPlate.sprite = redSprite;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}
