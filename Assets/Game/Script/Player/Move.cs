using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 moveVec;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    private Animator anim;
    [SerializeField] private GameObject sigareta;
    [SerializeField] private float coolSigaret = 1f;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetButton("Horizontal")) LogicMove();
        if (Input.GetButtonDown("Jump")) SigarLogic();
    }
    private void LogicMove()
    {
        moveVec = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + moveVec, speed * Time.deltaTime);
        spriteRenderer.flipX = moveVec.x < 0;
    }
    private void SigarLogic()
    {
        if(Input.GetButtonDown("Jump") && coolSigaret > 0)
        {
            coolSigaret--;
            speed = 0;
            anim.SetTrigger("Sigar");
            Invoke("NormalIdle", 2.05f);

        }
    }
    private void NormalIdle()
    {
        speed = 4;
        
    }
}
