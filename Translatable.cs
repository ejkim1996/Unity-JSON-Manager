using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Translatable : MonoBehaviour
{
    public string id;
    public string text;
    public int selected;
    public string[] options;

    GameObject textObject;

    public void Start()
    {
        textObject = gameObject;
        Debug.Log(textObject.name + " is currently being worked on");
        Text objectText = textObject.GetComponent<Text>();

        string fileName = options[selected];
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);

        if (File.Exists(filePath))
        {
            string dataAsJson = File.ReadAllText(filePath);
            //Debug.Log(dataAsJson);

            rootData root = JsonUtility.FromJson<rootData>(dataAsJson);

            bool idFound = false;
            for (int i = 0; i < root.information.Count; i++)
            {
                info inf = root.information[i];
                if (inf.id == id)
                {
                    Debug.Log("Text found. Loading . . .");
                    objectText.text = inf.text;
                    idFound = true;
                    break; //found the ID, break the loop now
                }
            }

            if (!idFound)
            {
                Debug.Log("Could not find the provided ID in the JSON file.");
            }

        }

    }

    public void GetFiles() {
        DirectoryInfo directory = new DirectoryInfo(Application.streamingAssetsPath);
        FileInfo[] info = directory.GetFiles();
        string[] fileNames = new string[info.Length];

        for (int i = 0; i < info.Length; i++) {
            fileNames[i] = Path.GetFileName(info[i].ToString());
        }
        options = fileNames;


    }

    public void UpdateJSON(string updateFileName, string idNameComponent, string textComponent)
    {
        
        //updateFile.id = idNameComponent;
        //updateFile.text = textComponent;
        string filePath = Path.Combine(Application.streamingAssetsPath, updateFileName);


        textObject = gameObject;
        textObject.GetComponent<Text>().text = textComponent;

        if (File.Exists(filePath)) 
        {
            string dataAsJson = File.ReadAllText(filePath);
            rootData root = JsonUtility.FromJson<rootData>(dataAsJson);

            bool idFound = false;
            //loop through text elements and edit if corresponding id found
            for (int i = 0; i < root.information.Count; i++) 
            {
                info inf = root.information[i];
                if (inf.id == idNameComponent) 
                {
                    Debug.Log(inf.text);
                    inf.text = textComponent;
                    Debug.Log(inf.text);
                    idFound = true;
                    Debug.Log("found id " + inf.id);
                    break; //found the ID, break the loop now
                }
            }

            // didn't find a matching ID
            if (!idFound) {
                // add new info object
                info addInfo = new info();
                addInfo.id = idNameComponent;
                addInfo.text = textComponent;
                root.information.Add(addInfo);
            }

            dataAsJson = JsonUtility.ToJson(root);
            File.WriteAllText(filePath, dataAsJson);
        } else 
        {
            Debug.Log("Error: File not found");
        }



    }

   

}

