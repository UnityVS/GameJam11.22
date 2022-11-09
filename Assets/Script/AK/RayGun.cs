using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayGun : MonoBehaviour
{
    private float _shotDistance = 20f;
    private Camera _camrea;

    private void Start()
    {
        _camrea = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Shot();
        }

        
    }
    void Shot()
    {
        RaycastHit hit;
        Ray ray = new Ray(_camrea.transform.position, _camrea.transform.forward);
        if (Physics.Raycast(ray, out hit, _shotDistance))
        {
            hit.collider.gameObject.GetComponent<Renderer>().material.color = Color.red;
            hit.collider.gameObject.AddComponent<Rigidbody>();
            Rigidbody rigidbody = hit.collider.GetComponent<Rigidbody>();
            rigidbody.AddForce(transform.forward, ForceMode.Impulse);
        }
       
    }
}
