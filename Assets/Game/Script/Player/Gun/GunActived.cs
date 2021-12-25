using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunActived : MonoBehaviour
{
    [SerializeField] private int WeaponSwitch = 0;
    private void Start()
    {
        SelectWeapon();
    }
    private void Update()
    {
        int currentWeapon = WeaponSwitch;
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if(WeaponSwitch >= transform.childCount -1)
            {
                WeaponSwitch = 0;
            }
            else
            {
                WeaponSwitch++;
            }
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if (WeaponSwitch <= 0)
            {
                WeaponSwitch = transform.childCount - 1;
            }
            else
            {
                WeaponSwitch--;
            }
        }
        if(currentWeapon != WeaponSwitch)
        {
            SelectWeapon();
        }
    }
   
    private void SelectWeapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if(i == WeaponSwitch)
            {
                weapon.gameObject.SetActive(true);
            }   
            else
            {
                weapon.gameObject.SetActive(false);
            }
            i++;
            
        }    
    }
}
