using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace LivingValkyrie.NodeEngine {

    /// <summary>
    /// Author: Matt Gipson
    /// Contact: Deadwynn@gmail.com
    /// Domain: www.livingvalkyrie.net
    /// 
    /// Description: SelectionNode 
    /// </summary>
    public abstract class SelectionNode : MonoBehaviour {
        #region Fields

        public bool unlocked = true;

        #endregion

        public abstract void OnSelect();

    }

}