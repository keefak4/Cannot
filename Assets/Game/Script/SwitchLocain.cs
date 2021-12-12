using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLocain : MonoBehaviour
{
    [SerializeField] private GameObject SceneBeta;
    [SerializeField] private GameObject SceneTera;
    [SerializeField] private GameObject SceneActive;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneActive.SetActive(true);
        SceneBeta.SetActive(false);
        SceneTera.SetActive(false);
    }
}
