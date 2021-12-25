using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveVecAndHor : MonoBehaviour
{
    [SerializeField] private float speedNormal;
    private SpriteRenderer spriteRend;
     private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;
    private void Start()
    {
        spriteRend = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        MoveLogic();
        ShiftSpeed();
        BreakoutLogic();
    }
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    private void MoveLogic()
    {
        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speedNormal;
        spriteRend.flipX = moveInput.x < 0f;
    }
    private void ShiftSpeed()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speedNormal = 6f;
        }
        else
        {
            speedNormal = 2f;
        }
    }
    private void BreakoutLogic()
    {
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            if(spriteRend.flipX == true)
            {
                rb.AddForce(-transform.right * 5000f);
            }
            else
            {
                rb.AddForce(transform.right * 5000f);

            }
        }
    }
}
