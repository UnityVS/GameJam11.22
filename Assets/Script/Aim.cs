using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    private Camera _camera;
    private Transform _aim;
    public Transform Player;
    

    private void Start()
    {
        _camera = Camera.main;
        _aim = GetComponent<Transform>();
    }

    private void LateUpdate()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(ray.origin, ray.direction * 50f);
        Plane plane = new Plane(Vector3.up, Vector3.zero);
        float distance;
        plane.Raycast(ray, out distance);
        Vector3 point = ray.GetPoint(distance);
        _aim.position = point;

      
        for (int i = 0; i < 200; i++)
        {
            Debug.DrawRay( new Vector3(-25, 0,-1) + Vector3.forward * 0.1f * i, Vector3.right, Color.yellow);
            Debug.DrawRay(new Vector3(-25, 0, -1) + Vector3.right * 0.1f * i, Vector3.forward, Color.yellow);
        }
    }

    
}
