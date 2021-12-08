using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 moveVec;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal")) LogicMove();
    }
    private void LogicMove()
    {
        moveVec = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + moveVec, speed * Time.deltaTime);
        spriteRenderer.flipX = moveVec.x < 0;
    }
}
