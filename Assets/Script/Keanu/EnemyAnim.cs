using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnim : MonoBehaviour
{
    private Animator _animation;

    private void Start()
    {

        _animation = GetComponent<Animator>();
        ActionEventGoneDove.EventOnDoveGone += SwitchAnimGone;
        ActionEventGoneDove.EventOnGetDamage += SwitchAnimGerDamage;

    }
  private void SwitchAnimGone()
    {
     //   _animation.SetTrigger();
    
    }
    private void SwitchAnimGerDamage()
    {

        _animation.SetTrigger("GetDamage");
        _animation.SetFloat("Blend", 1);
    }
}
