using System;
using System.Collections;

public class GridNode : IEnumerable {
    public GridNode leftNeighbor;
    public GridNode rightNeighbor;
    public GridNode topNeighbor;
    public GridNode bottomNeighbor;
    public GridNode topLeftNeighbor;
    public GridNode topRightNeighbor;
    public GridNode bottomLeftNeighbor;
    public GridNode bottomRightNeighbor;

    /// <summary>
    /// The tile that holds this grid node instance, should be set in start or awake for unity or in the constructor in standard c#.
    /// </summary>
    public GridTile tile;

    public GridNode() {}

    /// <summary>
    /// Initializes a new instance of the <see cref="GridNode"/> class.
    /// </summary>
    /// <param name="tile">The tile that holds this instance.</param>
    public GridNode(GridTile tile) {
        this.tile = tile;
    }

    public IEnumerator GetEnumerator() {
        if (topNeighbor != null) {
            yield return topNeighbor;
        }
        if (topRightNeighbor != null) {
            yield return topRightNeighbor;
        }
        if (rightNeighbor != null) {
            yield return rightNeighbor;
        }
        if (bottomRightNeighbor != null) {
            yield return bottomRightNeighbor;
        }
        if ( bottomNeighbor != null ) {
            yield return bottomNeighbor;
        }
        if (bottomLeftNeighbor != null) {
            yield return bottomLeftNeighbor;
        }
        if (leftNeighbor != null) {
            yield return leftNeighbor;
        }
        if (topLeftNeighbor != null) {
            yield return topLeftNeighbor;
        }
    }

}