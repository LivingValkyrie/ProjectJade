namespace LivingValkyrie.Grid {
    public class GridNode<TGridType> {
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

    }
}