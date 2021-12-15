using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeadCopStart : MonoBehaviour
{
    [SerializeField] private AudioSource deadMp3;
    [SerializeField] private GameObject deadCopObject;
    [SerializeField] private GameObject corpseCop;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(deadMp3, transform.position, Quaternion.identity);
        deadCopObject.gameObject.SetActive(false);
        corpseCop.gameObject.SetActive(true);
        Destroy(gameObject, 1f);
    }
}
