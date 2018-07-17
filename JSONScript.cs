using System.Collections;
using System.IO;
using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
public class JSONScript : MonoBehaviour {

    public string fileName;
	
    public void BuildJSON(string newFileName) {
        string filePath = Path.Combine(Application.streamingAssetsPath, newFileName);
        // Create a new file
        if (!File.Exists(filePath)) {
            RootAnimalData root = new RootAnimalData();

            string json = JsonUtility.ToJson(root);

            File.WriteAllText(filePath, json);

            Debug.Log("Success");
        } else {
            Debug.LogError("File with this name already exists!");


        }

    }

}



[System.Serializable]
public class rootData
{
    // the root data in the JSON file that contains all of the text elements and their associated id's
    public List<info> information;
}

[System.Serializable]
public class info {
    public string id;
    public string text;
}