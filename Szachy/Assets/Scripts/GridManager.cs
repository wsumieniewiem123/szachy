using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    //szerokoœæ i d³ugoœæ
    private int w = 8, h = 8;
    [SerializeField] private Tile tile;
    [SerializeField]private new Transform camera;

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
            }
            
        }
        camera.transform.position = new Vector3(4f, 4f, -10f);
    }
}
