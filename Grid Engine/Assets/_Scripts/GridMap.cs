using UnityEngine;
using System.Collections.Generic;
using UnityEditor;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: GridMap 
/// </summary>
public class GridMap : MonoBehaviour {
    #region Fields

    public int width, height;
    public string generatedMapName;
    public GameObject tilePrefab;

    [SerializeField]
    public GridTile[] map;

    #endregion
    
    public void GenerateMap() {
        map = new GridTile[width * height];

        if (transform.FindChild(generatedMapName)) {
            DestroyImmediate(transform.FindChild(generatedMapName).gameObject);
        }

        GameObject generatedMap = new GameObject(generatedMapName);
        generatedMap.transform.parent = this.transform;

        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                Vector3 tilePos = new Vector3(-width / 2 + 0.5f + x, -height / 2 + 0.5f + y);
                GameObject currTile = Instantiate(tilePrefab, tilePos, Quaternion.identity) as GameObject;
                currTile.transform.SetParent(generatedMap.transform);
                currTile.name = "Tile " + (( y * width) + x);

                GridTile tile = currTile.AddComponent<GridTile>();
                tile.xCoord = x;
                tile.yCoord = y;
                tile.gridMap = this;
                map[y * width + x] = tile;
                EditorUtility.SetDirty(tile);
            }
        }

        EditorUtility.SetDirty(this);
    }

}