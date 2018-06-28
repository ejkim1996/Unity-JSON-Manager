using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
[System.Serializable]
public class JSONScript : MonoBehaviour {

    public string fileName;
	
    public void BuildJSON(string newFileName) {
        string filePath = Path.Combine(Application.streamingAssetsPath, newFileName);
        // Create a new file
        if (!File.Exists(filePath)) {
            file myFile = new file();
            myFile.fileName = newFileName;

            string json = JsonUtility.ToJson(myFile);

            File.WriteAllText(filePath, json);

            Debug.Log("Success");
        } else {
            Debug.LogError("File with this name already exists!");
        }


    }

}

// File class with datafields

[System.Serializable]
public class file {
    public string fileName;
}