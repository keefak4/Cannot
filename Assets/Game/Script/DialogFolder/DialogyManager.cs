using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DialogyManager : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text dialogText;
    [SerializeField] private GameObject endObject;
    private BoxCollider2D boxCollider2;

    private Queue<string> sentences;
    private void Start()
    {
        sentences = new Queue<string>();
    }
    public void StartDialog(Dialog dialog)
    {
        Debug.Log("Tak" + dialog.Name);
        nameText.text = dialog.Name;
        sentences.Clear();
        foreach(string sentence in dialog.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentences();
    }

    public void DisplayNextSentences()
    {
        if(sentences.Count == 0)
        {
            EndDialog();
            return;
        }
        string sentence = sentences.Dequeue();
        StartCoroutine(TypeSentece(sentence));
    }
    IEnumerator TypeSentece(string sentence)
    {
        dialogText.text = "";
        foreach(char lette in sentence.ToCharArray())
        {
            dialogText.text += lette;
            yield return null;
        }
    }

    private void EndDialog()
    {
        Debug.Log("End");
        endObject.SetActive(false);
    }
}
