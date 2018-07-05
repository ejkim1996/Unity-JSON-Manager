using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Translatable : MonoBehaviour
{
    public string id;
    public int selected;
    public string[] options;
    public Text textObject;

    public void getFiles() {
        DirectoryInfo directory = new DirectoryInfo(Application.streamingAssetsPath);
        FileInfo[] info = directory.GetFiles();
        string[] fileNames = new string[info.Length];

        for (int i = 0; i < info.Length; i++) {
            fileNames[i] = Path.GetFileName(info[i].ToString());
        }
        options = fileNames;
    }

    public void UpdateJSON(string updateFileName, string fileNameComponent, string textComponent)
    {
        file updateFile = new file();
        updateFile.fileName = fileNameComponent;
        updateFile.text = textComponent;
        string filePath = Path.Combine(Application.streamingAssetsPath, updateFileName);
        string json = JsonUtility.ToJson(updateFile);
        File.WriteAllText(filePath, json);
    }

}

