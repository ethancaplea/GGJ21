using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGeneration : MonoBehaviour
{
    public int mapWidth;       // width of the whole map
    public int mapHeight;      // height of the whole map
    public GameObject[] tiles;  // available tile types
    int tileWidth = 50;      // width of each tile
    int tileHeight = 50;     // height of each tile

    private void Start()
    {
        ////////////////////////////// does not work because the scale is set to 1 in other scenes
        // get width of tiles
        //tileWidth = (int)tiles[0].transform.localScale.x;
        // get height of tiles
        //tileHeight = (int)tiles[0].transform.localScale.z;

        // call generate tile map function
        GenerateTileMap(tileWidth, tileHeight);

    }

    // randomly generates the map base (tile types)
    void GenerateTileMap(int _tileWidth, int _tileHeight)
    {
        int xCoord = 0;
        int zCoord = 0;

        for (zCoord = 0; zCoord <= ((mapHeight-1)*100); zCoord += _tileHeight)  // for each z
        {
            for (xCoord = 0; xCoord <= ((mapWidth-1)*100); xCoord+= _tileWidth)   // for each x
            {
                // make a tile at passed in coords
                Instantiate(tiles[Random.Range(0, 2)], new Vector3(xCoord, .1f, zCoord), Quaternion.identity);
            }
            // set xcoord back to zero
            xCoord = 0;
        }
    }

}
