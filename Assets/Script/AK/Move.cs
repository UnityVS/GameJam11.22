using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Vector3 _position;
    public float angle;
    private Camera _camera;
   


    private void Start()
    {
        _camera = Camera.main;
    }
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = _camera.transform.position.z;
        _position = _camera.ScreenToWorldPoint(mousePosition);
        transform.LookAt(_position);
        
    }

   
}
