using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLocain : MonoBehaviour
{
    [SerializeField] private GameObject Scene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Scene.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Scene.SetActive(false);
        }
    }
}
