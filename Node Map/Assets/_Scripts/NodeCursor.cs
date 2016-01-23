using UnityEngine;
using System.Collections.Generic;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: CursorNode 
/// </summary>
public class NodeCursor : MonoBehaviour {
    #region Fields

    public MapNode startingNode;
    MapNode selectedNode;
    
    #endregion

    void Start() {
        selectedNode = startingNode;
        Move();
    }

    void Update() { 
        AttemptMove();
        if (Input.GetKeyDown(KeyCode.Return)) {
            selectedNode.OnSelect();
        }
    }

    void Move() {
        transform.position = selectedNode.transform.position;
    }

    public virtual void AttemptMove() {
        //take input to select node
        if (Input.GetKeyDown(KeyCode.A)) {
            //check if node exist and is unlocked
            if (selectedNode.leftNode != null) {
                if ( selectedNode.leftNode.unlocked) {
                    //all good
                    selectedNode = selectedNode.leftNode;
                    //update position
                    Move();
                } else {
                    //play locked sound
                }
            } else {
                //play doesnt exist sound
            }
        }
    }

}