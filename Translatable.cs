using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Translatable : MonoBehaviour
{
    public string id;
    public options JSONFile;

    public enum options
    {
        Option1,
        Option2,
        Option3
    };

}

