using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TileMapDialogCop5 : MonoBehaviour
{
    [SerializeField] private Text text;

    private void Start()
    {
        StartCoroutine(TextOutput("(К)Следуй к пр Революции,там ты встретишь Виктора,он даст тебе всю необходимиую информацию", 0.05f));
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
