using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDead : BasicUnity
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * 200f);
            ReciewDamage();
        }
    }
}
