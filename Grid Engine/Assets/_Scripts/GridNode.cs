using System;
using System.Collections;

namespace LivingValkyrie.Grid {
    public class GridNode<TGridType> : IEnumerable {
        public GridNode<TGridType> leftNeighbor;
        public GridNode<TGridType> rightNeighbor;
        public GridNode<TGridType> topNeighbor;
        public GridNode<TGridType> bottomNeighbor;
        public GridNode<TGridType> topLeftNeighbor;
        public GridNode<TGridType> topRightNeighbor;
        public GridNode<TGridType> bottomLeftNeighbor;
        public GridNode<TGridType> bottomRightNeighbor;

        /// <summary>
        /// The tile that holds this grid node instance, should be set in start or awake for unity or in the constructor in standard c#.
        /// </summary>
        public TGridType tile;

        public GridNode() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="GridNode{TGridType}"/> class.
        /// </summary>
        /// <param name="tile">The tile that holds this instance.</param>
        public GridNode(TGridType tile) {
            this.tile = tile;
        }

        public IEnumerator GetEnumerator() {
            //test
            yield return leftNeighbor;
            yield return rightNeighbor;
            yield return topNeighbor;
            yield return bottomNeighbor;
            yield return topLeftNeighbor;
            yield return topRightNeighbor;
            yield return bottomLeftNeighbor;
            yield return bottomRightNeighbor;
            
        }
    }
}