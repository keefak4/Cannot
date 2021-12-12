using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActive : MonoBehaviour
{
    [SerializeField] private GameObject ButtonClick;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ButtonClick.SetActive(true);  
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ButtonClick.SetActive(false);
    }
}
