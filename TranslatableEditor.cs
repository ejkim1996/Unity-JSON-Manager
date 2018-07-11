using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

[CustomEditor(typeof(Translatable))]
public class TranslatableEditor : Editor
{

    public override void OnInspectorGUI()
    {
        Translatable myTarget = (Translatable)target;
        // Call files
        myTarget.id = EditorGUILayout.TextField("ID", myTarget.id);

        myTarget.GetFiles();
        myTarget.selected = EditorGUILayout.Popup(myTarget.selected, myTarget.options);

        if (GUILayout.Button("Update JSON File with Text Component"))
        {
            // Finds the text component of the Game Object and corresponding file
            string fileNameComponent = myTarget.id;
            string textComponent = GameObject.Find("SampleGameObject").GetComponent<Text>().text;
            string selectedFile = myTarget.options[myTarget.selected];

            myTarget.UpdateJSON(selectedFile, fileNameComponent, textComponent);
            Debug.Log("File was updated with text component.");
        }

    }
}
