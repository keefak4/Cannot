using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CopZ3 : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Start()
    {
        StartCoroutine(TextOutput("(К)Я с тобой в шутки не буду играть!Нарик.Каждый вечер будешь ко мне подходить отмечаться.Тебе ясно?", 0.05f));
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
