using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiteTrigger : MonoBehaviour
{
    [SerializeField] private GameObject leteDialogy;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            leteDialogy.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            leteDialogy.SetActive(false);

        }
    }

}
