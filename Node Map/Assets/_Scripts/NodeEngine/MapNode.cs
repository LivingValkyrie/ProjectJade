using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

namespace LivingValkyrie.NodeEngine {

    /// <summary>
    /// Author: Matt Gipson
    /// Contact: Deadwynn@gmail.com
    /// Domain: www.livingvalkyrie.com
    /// 
    /// Description: MapNode 
    /// </summary>
    public class MapNode : SelectionNode {
        #region Fields

        public string mapScene;

        public MapNode leftNode, rightNode, topNode, bottomNode;

        #endregion

        public override void OnSelect() {
            //play selected sound
            SceneManager.LoadScene(mapScene);
        }
    }
}