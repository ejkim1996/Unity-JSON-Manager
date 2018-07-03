using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class Translatable : MonoBehaviour
{
    public string id;
    public int selected;
    public string[] options;

    public string[] getFiles() {
        DirectoryInfo directory = new DirectoryInfo(Application.streamingAssetsPath);
        FileInfo[] info = directory.GetFiles();
        string[] fileNames = new string[info.Length];

        for (int i = 0; i < info.Length; i++) {
            fileNames[i] = Path.GetFileName(info[i].ToString());
        }

        return fileNames;
    }

}

