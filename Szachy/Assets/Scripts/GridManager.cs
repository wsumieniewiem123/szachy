using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    //szerokoœæ i d³ugoœæ
    private int w = 8, h = 8;
    [SerializeField] public Tile tile;
    [SerializeField]private new Transform camera;
    [SerializeField] private Pawn _pawn;

    void Start()
    {
        GridGenerator();
    }
    void GridGenerator() 
    {
        for (int x = 0; x < w; x++)
        {
            for (int y = 0; y < h; y++)
            {
                var spawnedTile = Instantiate(tile, new Vector3(x, y), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";

                bool isOffset = (x % 2 == 0 && y % 2 != 0) || (x % 2 != 0 && y % 2 == 0);
                spawnedTile.Init(isOffset);

                if (y == 1)
                {
                    var spawnedPawn = Instantiate(_pawn, new Vector3(x, y), Quaternion.identity);
                    spawnedPawn.name = $"Pawn {x}";
                }
            }
            
        }
        camera.transform.position = new Vector3(4f, 4f, -10f);
    }
}
