using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialog 
{
    public string Name;
    [TextArea(4,15)]
     public string[] sentences;
}
