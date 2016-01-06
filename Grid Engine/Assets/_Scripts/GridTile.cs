using UnityEngine;
using System.Collections.Generic;
using LivingValkyrie.Grid;

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
    public TileType tileType;
    public GridMap map;
    public int xCoord, yCoord;
    public GridNode<GridTile> node;

    public delegate void TileEventHandler();

    public event TileEventHandler typeChanged;
    public event TileEventHandler classChanged;
    public event TileEventHandler neighborChanged; //might not need

    #endregion

    void OnEnable() {
        node = new GridNode<GridTile>(this);

        //AssignNeighbors(); cant run this til after entire grid is made. do this in awake?
    }

    void OnDisable() {}

    public void AssignNeighbors() {
        //get neighbors
        List<GridTile> neighbors = GridHelper.FindNeighbors(map.map, xCoord, yCoord, GridHelper.NeighborType.All);

        //for each
        foreach (GridTile neighbor in neighbors) {
            //prolly not the most effiecent, but more readable
            bool xLeft = false, xSame = false, xRight = false;
            bool yAbove = false, ySame = false, yBelow = false;

            //check x compared to neighbors and set proper x bool
            if (neighbor.xCoord == xCoord) {
                xSame = true;
            } else if (neighbor.xCoord > xCoord) {
                xRight = true;
            } else if (neighbor.xCoord < xCoord) {
                xLeft = true;
            }

            //check y compared to neighbors and set proper y bool
            if (neighbor.yCoord == yCoord) {
                ySame = true;
            } else if (neighbor.yCoord > yCoord) {
                yAbove = true;
            } else if (neighbor.yCoord < yCoord) {
                yBelow = true;
            }

            //check all combinations to set neighbor to proper variable
            if (xLeft) {
                if (yBelow) {
                    node.bottomLeftNeighbor = neighbor.node;
                } else if (ySame) {
                    node.leftNeighbor = neighbor.node;
                } else if (yAbove) {
                    node.topLeftNeighbor = neighbor.node;
                }
            } else if (xSame) {
                if (yBelow) {
                    node.bottomNeighbor = neighbor.node;
                } else if (ySame) {
                    //this node, cant happen
                } else if (yAbove) {
                    node.topNeighbor = neighbor.node;
                }
            } else if (xRight) {
                if (yBelow) {
                    node.bottomRightNeighbor = neighbor.node;
                } else if (ySame) {
                    node.rightNeighbor = neighbor.node;
                } else if (yAbove) {
                    node.topRightNeighbor = neighbor.node;
                }
            }
        }
    }

    void OnClassChange() {}
    void OnTypeChange() {}
    void OnNeighborChange() {}
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