using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CastSceneActivator : MonoBehaviour
{
    [SerializeField] private GameObject castScene;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        castScene.gameObject.SetActive(true);
    }
}
