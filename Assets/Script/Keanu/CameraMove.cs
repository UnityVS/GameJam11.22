using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private float rotationY;
    private float rotationX;
    public float RotateMin = -90;
    public float RotateMax = 90f;
    public float MouseSens = 300f;

    public Transform Pointer;



    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        //transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * Speed,0, Input.GetAxis("Vertical") * Time.deltaTime * Speed);
        
      
        float MouseX = Input.GetAxis("Mouse X") * MouseSens * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * MouseSens * Time.deltaTime;

        rotationX -= MouseY;
        rotationY -= MouseX;

        rotationX = Mathf.Clamp(rotationX, RotateMin, RotateMax);
        rotationY = Mathf.Clamp(rotationY, RotateMin, RotateMax);
        transform.localRotation = Quaternion.Euler(rotationX, -rotationY, 0);
        

        RayAim();
    }

    void RayAim()
    {
        Ray ray = new Ray(transform.position, transform.forward);
       // Debug.DrawRay(transform.position, transform.forward*100, Color.red);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Pointer.position = hit.point;
           // Debug.Log("hit.point " + hit.point);
        }

    
    
    
    }
}
