using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: MapNode 
/// </summary>
public class MapNode : MonoBehaviour {
    #region Fields

    public MapNode leftNode, rightNode, topNode, bottomNode;
    public bool unlocked = true;

    #endregion

    public void OnSelect() {
        //throw new System.NotImplementedException();
    }
}