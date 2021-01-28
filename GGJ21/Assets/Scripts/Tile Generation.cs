using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    public GameObject[] tiles; // available tile types
    int tileWidth;      // width of each tile
    int tileHeight;     // height of each tile

    private void Start()
    {
        tileWidth = (int)tiles[0].transform.localScale.x;
        tileHeight = (int)tiles[0].transform.localScale.z;
    }

    // randomly generates the map base (tile types)
    public float[,] GenerateTileMap(int mapHeight, int mapWidth, float scale)
    {
        float[,] tileMap = new float[mapWidth, mapHeight];  // the whole map base

        for (int zCoord = 0; zCoord < mapHeight; zCoord++)  // for each z
        {
            for (int xCoord = 0; xCoord < mapWidth; xCoord++)   // for each x
            {
                // make a tile at passed in coords
                Instantiate(tiles[0], new Vector3(xCoord, 1, zCoord), Quaternion.identity);

                // increment where to place the next tile in the row
                xCoord *= tileWidth;
            }

            // increment where to place the next row of tiles
            zCoord *= tileHeight;
        }

        return tileMap;
    }

}
