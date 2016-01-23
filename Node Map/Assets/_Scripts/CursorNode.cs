using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: CursorNode 
/// </summary>
public abstract class CursorNode : MonoBehaviour {
    #region Fields

    public CursorNode leftNode, rightNode, topNode, bottomNode;
    
    #endregion

    public abstract void OnSelect();

    public virtual void Move() {
        //take input to select node
    }

}