using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: GridTile
/// </summary>
public class GridTile : MonoBehaviour {
    #region Fields

    public TileClass tileClass;

    #endregion
}

public enum TileType {
    Walkable,
    Unwalkable
}

public enum TileClass {
    Dirt,
    Water,
    Stone
}