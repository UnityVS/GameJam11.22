using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionAnim : MonoBehaviour
{
    private Animator _animation;
    
    private void Start()
    {
      
        _animation = GetComponent<Animator>();
    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {   
            _animation.SetFloat("Throw", 1);
            Invoke("StopThrow", 0.5f);
        }
    }
    public void StopThrow()
    {
        _animation.SetFloat("Throw", 0);

    }
    


}
