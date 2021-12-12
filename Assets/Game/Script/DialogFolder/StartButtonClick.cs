using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButtonClick : MonoBehaviour
{
    [SerializeField] private GameObject DialogTablo;
    public void ClickButton()
    {
        DialogTablo.SetActive(true);
    }
}
