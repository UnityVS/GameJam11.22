using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointToGoneDoves : MonoBehaviour
{
    private Transform _player;

    private void Start()
    {
        _player = FindObjectOfType<KeanuThrow>().transform;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Enemy>() is Enemy enemy)
        {
            enemy.GetComponent<Rigidbody>().velocity = Vector3.zero;
           
            //enemy.GetComponent<Transform>().LookAt(_player);

        }
    }
}
