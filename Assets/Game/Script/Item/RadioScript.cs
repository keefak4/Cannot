using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioScript : MonoBehaviour
{
    [SerializeField] private AudioSource radioGoloc;
    [SerializeField] private GameObject radioObject;
    private SpriteRenderer sprite;
    private BoxCollider2D box;
    private void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
        box = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Instantiate(radioGoloc, transform.position, Quaternion.identity);
            radioObject.SetActive(true);
            sprite.enabled = false;
            box.enabled = false;
            Invoke("ResetItem", 4f);
        }
    }
    private void ResetItem()
    {
        radioObject.SetActive(false);
        Destroy(gameObject);
    }
}
