using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AkBullet : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        TargetCollider target = collision.collider.GetComponent<TargetCollider>();
        if (target)
             
        {
            Debug.Log("target");
            if (!target.GetComponent<Rigidbody>())
            {
                target.gameObject.AddComponent<Rigidbody>();
                Rigidbody rigidbody = target.GetComponent<Rigidbody>();
                rigidbody.AddForce(transform.forward, ForceMode.Impulse);
                rigidbody.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
                target.Damage();
            }
        
        }

    }
}
