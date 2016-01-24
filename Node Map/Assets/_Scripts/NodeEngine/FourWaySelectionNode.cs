namespace LivingValkyrie.NodeEngine {
    /// <summary>
    /// Author: Matt Gipson
    /// Contact: Deadwynn@gmail.com
    /// Domain: www.livingvalkyrie.net
    /// 
    /// Description: FourWaySelectionNode 
    /// </summary>
    public abstract class FourWaySelectionNode : SelectionNode {
        #region Fields

        public SelectionNode leftNode, rightNode, topNode, bottomNode;

        #endregion
    }
}