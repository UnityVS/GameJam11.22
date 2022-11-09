using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour
{
    
    public GameObject BulletPref;
    private float _reloadTime;


  
    private void Update()
    {
        Shooting();
        if (_reloadTime >= 0)
        {
            _reloadTime -= Time.deltaTime;
        }
    }

    private void Shooting()
    {
        if (_reloadTime <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                GameObject newBullet = Instantiate(BulletPref, transform.position, transform.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(transform.forward * 50, ForceMode.Impulse);
                Destroy(newBullet, 3f);

            }
            _reloadTime = 0.1f;
        }
    }
}
