using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target;
    private void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z);
    }
}
