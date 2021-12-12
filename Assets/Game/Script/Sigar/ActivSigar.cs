using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivSigar : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            anim.SetTrigger("Sigar");
        }
    }
}
