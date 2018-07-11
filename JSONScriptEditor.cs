using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(JSONScript))]
public class JSONScriptEditor : Editor {

	public override void OnInspectorGUI()
	{
        JSONScript myTarget = (JSONScript)target;

        myTarget.fileName = EditorGUILayout.TextField("File Name", myTarget.fileName);
        
        if(GUILayout.Button("Build JSON File")) {
            myTarget.BuildJSON(myTarget.fileName);
        }

	}
}
