using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolManager : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField]private int positionPatrol;
    [SerializeField] private Transform startPosion;
    private bool movingRight;
    private Transform player;
    [SerializeField] private float stopDistancePlayer;
    private bool chill = false;
    private bool agry = false;
    private bool getBack = false;


    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if (Vector2.Distance(transform.position, startPosion.transform.position) < positionPatrol && agry == false)
        {
            chill = true;
        }
        if(Vector2.Distance(transform.position,player.position) < stopDistancePlayer)
        {
            agry = true;
            chill = false;
            getBack = false;
        }
        if (Vector2.Distance(transform.position, player.position) > stopDistancePlayer)
        {
            getBack = true;
            agry = false;
        }
        if (chill == true)
        {
            Chill();
        }
        else if (agry == true)
        {
            Agry();
        }
        else if (getBack == true)
        {
            GetBack();
        }
    }
    void Chill()
    {
        if(transform.position.x > startPosion.transform.position.x + positionPatrol)
        {
            movingRight = false;
        }
        else if(transform.position.x < startPosion.transform.position.x - positionPatrol)
        {
            movingRight = true;
        }
        if(movingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
    void Agry()
    {
        transform.position = Vector2.MoveTowards(transform.position,player.position,speed * Time.deltaTime);
    }
    void GetBack()
    {
        transform.position = Vector2.MoveTowards(transform.position, startPosion.position, speed * Time.deltaTime);
    }

}
