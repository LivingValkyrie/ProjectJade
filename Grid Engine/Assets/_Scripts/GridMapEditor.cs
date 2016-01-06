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

    void Awake() {
        //type objectName = (type)target;
    }

    public override void OnInspectorGUI() {
        base.OnInspectorGUI();

        GridMap map = target as GridMap;

        if (GUILayout.Button("Build Map")) {
            map.GenerateMap();
        }

    }

}