using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShotMove : MonoBehaviour
{
    private float rotationY;
    public float RotateMinY = -40f;
    public float RotateMaxY = 40f;
    public float Speed = 10f;
    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed,0, Input.GetAxis("Vertical") * Time.deltaTime * Speed);
        //float rotationX = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Speed;
        //rotationY +=  Input.GetAxis("Mouse Y") * Speed;
        //rotationY = Mathf.Lerp(rotationY, RotateMinY, RotateMaxY);
        //transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);
    }
}
