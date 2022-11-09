using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetCollider : MonoBehaviour
{
    public void Damage()
    {
        GetComponent<Renderer>().material.color = Color.red;
    
    }
}
