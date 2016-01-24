namespace LivingValkyrie.NodeEngine {
    /// <summary>
    /// Author: Matt Gipson
    /// Contact: Deadwynn@gmail.com
    /// Domain: www.livingvalkyrie.net
    /// 
    /// Description: EightWaySelectionNode 
    /// </summary>
    public abstract class EightWaySelectionNode : FourWaySelectionNode {
        #region Fields

        public SelectionNode topLeftNode, topRightNode, bottomLeftNode, bottomRightNode;

        #endregion
    }
}