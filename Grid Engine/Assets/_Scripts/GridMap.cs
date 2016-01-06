using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: GridMap 
/// </summary>
public class GridMap : MonoBehaviour {
    #region Fields

    public Vector2 mapSize;
    public GameObject tilePrefab;

    public GridTile[,] map;

    #endregion

    public void GenerateMap() {
        for (int x = 0; x < mapSize.x; x++) {
            for (int y = 0; y < mapSize.y; y++) {
                Vector3 tilePos = new Vector3(-mapSize.x / 2 + 0.5f + x, -mapSize.y / 2 + 0.5f + y);
                GameObject currTile = Instantiate(tilePrefab, tilePos, Quaternion.identity) as GameObject;
                currTile.transform.SetParent(this.transform);
                currTile.name = "Tile " + ((x * mapSize.y) + y);
                GridTile tile = currTile.AddComponent<GridTile>();
                tile.xCoord = x;
                tile.yCoord = y;
                //map[x, y] = currTile.GetComponent<GridTile>();
            }
        }
    }

}