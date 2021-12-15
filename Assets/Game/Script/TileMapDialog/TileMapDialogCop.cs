using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TileMapDialogCop : MonoBehaviour
{
    [SerializeField] private Text text;
    private void Start()
    {
        StartCoroutine(TextOutput("(К)Слушай Джозеф,мне правда всё равно,сдохнешь ты здесь от пули или от накротиков.Найти главу Банды Чоколас,это будет твоей искупительной миссией.", 0.05f));
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
