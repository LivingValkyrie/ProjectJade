using UnityEngine;
using System.Collections.Generic;
using LivingValkyrie.NodeEngine;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: CursorNode 
/// </summary>
public class NodeCursor : MonoBehaviour {
    #region Fields

    //need to create seperate cursor classes for 4 and 8 way nodes
    //need to create cursor for map nodes
    //may need to scrap super classes as inheritance doesnt do what im wanting without downcasting

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

        //play move sound
    }

    public void AttemptMove() {
        //take input to select node
        if (Input.GetKeyDown(KeyCode.A)) {
            //check if node exist and is unlocked
            if (selectedNode.leftNode != null && selectedNode.leftNode.unlocked) {
                //all good
                selectedNode = selectedNode.leftNode;
                Move();
            } else {
                //play locked sound / doesnt exist sound
            }
        } else if (Input.GetKeyDown(KeyCode.D)) {
            //check if node exist and is unlocked
            if (selectedNode.rightNode != null && selectedNode.rightNode.unlocked) {
                //all good
                selectedNode = selectedNode.rightNode;
                Move();
            } else {
                //play locked sound / doesnt exist sound
            }
        } else if ( Input.GetKeyDown( KeyCode.W ) ) {
            //check if node exist and is unlocked
            if ( selectedNode.topNode != null && selectedNode.topNode.unlocked ) {
                //all good
                selectedNode = selectedNode.topNode;
                Move();
            } else {
                //play locked sound / doesnt exist sound
            }
        } else if ( Input.GetKeyDown( KeyCode.S ) ) {
            //check if node exist and is unlocked
            if ( selectedNode.bottomNode != null && selectedNode.bottomNode.unlocked ) {
                //all good
                selectedNode = selectedNode.bottomNode;
                Move();
            } else {
                //play locked sound / doesnt exist sound
            }
        }
    }

}