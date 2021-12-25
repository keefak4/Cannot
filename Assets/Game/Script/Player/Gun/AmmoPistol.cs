using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPistol : MonoBehaviour
{
    [SerializeField] private float speedAmmo;
    private void Start()
    {
        Invoke("DestroyAmmo", 1.5f);
    }
    private void Update()
    {
        transform.Translate(transform.right * speedAmmo * Time.deltaTime);
    }
    private void DestroyAmmo()
    {
        Destroy(gameObject);
    }
}
