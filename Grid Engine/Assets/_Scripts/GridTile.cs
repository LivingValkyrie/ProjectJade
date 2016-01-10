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
    public TileType tileType;
    public GridMap gridMap;
    public int xCoord, yCoord;
    public GridNode node;

    /// <summary>
    /// Gets the index of this tile in gridmap's map array. if -1 then gridmap is null
    /// </summary>
    /// <value>
    /// The index.
    /// </value>
    public int Index {
        get {
            if (gridMap != null) {
                return (gridMap.width * yCoord) + xCoord;
            }

            return -1;
        }
    }

    #endregion

    void Awake() {
        node = new GridNode(this);
    }

    public void CalculateBorders() {
        AssignNeighbors();

        if (node.leftNeighbor != null) {
            
        }
    }

    #region Neighbor Methods

    public void AssignNeighbors() {
        //get neighbors
        List<GridTile> neighbors = FindNeighbors(gridMap.map, xCoord, yCoord, NeighborType.All);

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

    public List<GridTile> FindNeighbors(GridTile[] grid, int gridX, int gridY, NeighborType type, int radius = 1) {
        List<GridTile> neighborsToReturn = new List<GridTile>();

        for (int x = -radius; x <= radius; x++) {
            for (int y = -radius; y <= radius; y++) {
                if (x == 0 && y == 0) {
                    continue; //inside current node
                }

                int checkX = gridX + x;
                int checkY = gridY + y;

                //check if in bounds
                //need to figure out logic to replace get lengths
                if (checkX >= 0 && checkX < gridMap.width && checkY >= 0 && checkY < gridMap.height) {
                    switch (type) {
                        case NeighborType.Vertical:

                            //same vertical plane
                            if (x == 0) {
                                neighborsToReturn.Add(grid[Index]);
                            }
                            break;
                        case NeighborType.Horizontal:

                            //same horizontal plane
                            if (y == 0) {
                                neighborsToReturn.Add(grid[Index]);
                            }
                            break;
                        case NeighborType.Cross:

                            //vertical and horizontal planes are both the same
                            if (x == 0 || y == 0) {
                                neighborsToReturn.Add(grid[Index]);
                            }
                            break;
                        case NeighborType.Diagonal:

                            //test if location has the same x and y compared to the base node
                            if (Mathf.Abs(checkX - gridX) == Mathf.Abs(checkY - gridY)) {
                                neighborsToReturn.Add(grid[Index]);
                            }
                            break;
                        case NeighborType.All:

                            //add all results
                            neighborsToReturn.Add(grid[Index]);
                            break;
                    }
                }
            }
        }

        //return
        return neighborsToReturn;
    }

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