using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TileMapDialogCop3 : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Start()
    {
        StartCoroutine(TextOutput("(К)Идиот!Я с тобой в игры играть не буду.Будешь подходить ко мне,отмечаться,каждый раз как я тебя наберу,ясно?", 0.05f));
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
