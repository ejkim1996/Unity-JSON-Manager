using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Translatable))]
public class TranslatableEditor : Editor
{

    public override void OnInspectorGUI()
    {
        Translatable myTarget = (Translatable)target;
        myTarget.id = EditorGUILayout.TextField("ID", myTarget.id);
        myTarget.selected = EditorGUILayout.Popup(myTarget.selected, myTarget.getFiles());

        if (GUILayout.Button("Update with Text Component"))
        {
            DirectoryInfo directory = new DirectoryInfo(Application.streamingAssetsPath);
            FileInfo[] info = directory.GetFiles();
            foreach (FileInfo f in info)
            {
                Debug.Log(Path.GetFileName(f.ToString()));
            }
        }

    }
}
