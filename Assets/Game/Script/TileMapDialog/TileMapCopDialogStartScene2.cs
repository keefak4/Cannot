using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileMapCopDialogStartScene2 : MonoBehaviour
{
    [SerializeField] private Text text;
    private void Start()
    {
        StartCoroutine(TextOutput("(К)Боже...Заткни свой рот,по приезду тебе всё расскажут", 0.05f));
    }
    private IEnumerator TextOutput(string str, float speedText)
    {
        foreach (var sum in str)
        {
            print(sum);
            text.text += sum;
            yield return new WaitForSeconds(speedText);
        }
    }
}
