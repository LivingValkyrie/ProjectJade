using UnityEngine;
using System.Collections;
using UnityEditor;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: GridTileEditor is a custom editor
/// </summary>
[CustomEditor(typeof(GridTile))]
public class GridTileEditor : Editor {
    #region Fields
	
    #endregion

	void Awake(){
		//type objectName = (type)target;
	}
	
	public override void OnInspectorGUI(){

        base.OnInspectorGUI();

        GridTile tile = (GridTile)target;

	    if (GUILayout.Button("prove array exist")) {
	        Debug.Log(tile.gridMap.map.GetHashCode() + " map hash from tile inspector");
            Debug.Log(tile.gridMap.GetHashCode() + " gridmap hash from tile inspector");
	    }

	} 

}