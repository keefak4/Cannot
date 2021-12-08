using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CorDiaMetroTwo : MonoBehaviour
{
    [SerializeField] private Text text;
    private void Start()
    {
        StartCoroutine(TextOutput("(К)Ты не в том положении,чтобы выбирать город.Теперь ты наша ищейка", 0.05f));
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
