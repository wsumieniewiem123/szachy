using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : MonoBehaviour
{   
    [SerializeField] private Tile possibleMoves;
    //[SerializeField] private SpriteRenderer _renderer;
    [SerializeField] private Color color;
    bool isClicked;
    // Start is called before the first frame update
    void Start()
    {
        isClicked = false; 
    }


    private void OnMouseDown()
    {
        isClicked = true;
    }
    void whenClicked()
    {
        if (isClicked == true)
        {
            
            possibleMoves._highlight.SetActive(true);
            var spawnedTile1 = Instantiate(possibleMoves, new Vector3(transform.position.x, transform.position.y + 1), Quaternion.identity);
            spawnedTile1.name = $"Tile pawn 1";
            var spawnedTile2 = Instantiate(possibleMoves, new Vector3(transform.position.x, transform.position.y + 2), Quaternion.identity);
            spawnedTile2.name = $"Tile pawn 2";
            spawnedTile1._renderer.color = color;
            spawnedTile2._renderer.color = color;

        }
    }
    void Update()
    {
        whenClicked();
    }
}
