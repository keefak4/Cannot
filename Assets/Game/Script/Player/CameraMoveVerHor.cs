using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveVerHor : MonoBehaviour
{
    [SerializeField] private Transform PlayerTransform;
    private void Update()
    {
        transform.position = new Vector3(PlayerTransform.transform.position.x, transform.position.y, transform.position.z);
    }
}
