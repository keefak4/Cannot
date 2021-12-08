using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CorDialMetro : MonoBehaviour
{
    [SerializeField] private Text text;
    private void Start()
    {
        StartCoroutine(TextOutput("(Д)Ненавижу этот город", .1f));
    }
    private IEnumerator TextOutput(string str,float speedText)
    {
        foreach(var sum  in str)
        {
            print(sum);
            text.text += sum;
            yield return new WaitForSeconds(speedText);        
        }
    }
}
