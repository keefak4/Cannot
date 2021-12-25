using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistoletClassic : MonoBehaviour
{
    [SerializeField] private GameObject ammo;
    [SerializeField] private Transform shordDir;
    private float timeShot;
    private float startTime;
    //Боеприпасы
    [SerializeField] private int fullAmme = 12;//Максимум сколько,могу переносить пуль
    [SerializeField] private int currentAmme;//
    [SerializeField] private int allAmme;//Cостояние боевприпасов в обойне
    private void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition)- transform.position;
        if (timeShot <= 0)
        {
            if (Input.GetKeyDown(KeyCode.L) && currentAmme > 0)
            {
                Instantiate(ammo, shordDir.position, Quaternion.identity);
                timeShot = startTime;
                currentAmme--;
            }
        }
        else
        {
            timeShot -= Time.deltaTime;
        }
       if(Input.GetKeyDown(KeyCode.R) && allAmme >0)
        {
            Reload();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PistolClip"))
        {
            allAmme += 12;
            Destroy(collision.gameObject,0.1f);
        }
    }
    public void Reload()
    {
        int reson = 12 - currentAmme;
        if (allAmme >= reson)
        {
            allAmme = allAmme - reson;
            currentAmme = 12;
        }
        else
        {
            currentAmme = currentAmme + allAmme;
            allAmme = 0;
        }
    }
}
