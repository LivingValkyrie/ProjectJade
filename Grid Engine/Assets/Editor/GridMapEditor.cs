using UnityEngine;
using System.Collections;
using UnityEditor;

/// <summary>
/// Author: Matt Gipson
/// Contact: Deadwynn@gmail.com
/// Domain: www.livingvalkyrie.com
/// 
/// Description: GridMapEditor is a custom editor
/// </summary>
[CustomEditor(typeof (GridMap))]
public class GridMapEditor : Editor {
    #region Fields

    #endregion
    
    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        GridMap map = (GridMap)target;

        if (GUILayout.Button("Build Map")) {
            map.GenerateMap();
        }

    }

}