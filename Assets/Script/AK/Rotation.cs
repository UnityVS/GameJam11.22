using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed;
    private void Update()
    {
        GetComponent<Rigidbody>().angularVelocity = Vector3.up*speed;
    }
}
