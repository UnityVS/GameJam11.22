using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, Idamagable
{
    //private  _direction;
    private Transform _playerPosition;
    private float _speed;
    private int _healh;
    private Rigidbody _rigidbody;

    private Transform _pointToGoneDove;

    public bool isGone = false;
    public Animator Animation;


    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _playerPosition = FindObjectOfType<KeanuThrow>().transform;
        _pointToGoneDove = FindObjectOfType<PointToGoneDoves>().transform;
    }
    
    
    private void FixedUpdate()
    {
        
        
        if (_healh > 0)
        {
            Vector3 _direction = _playerPosition.position - transform.position;
            _rigidbody.velocity = _direction.normalized * _speed;
            transform.LookAt(_playerPosition);
        }
        else 
        {
            Vector3 directionToGone = _pointToGoneDove.position - transform.position;
            _rigidbody.velocity = directionToGone.normalized * 0;
            transform.LookAt(_pointToGoneDove);
            _rigidbody.velocity = directionToGone.normalized * _speed*2;
        }
        
    }

    public void Initialization(float speed, int healh)
    {
        _speed = speed;
        _healh = healh;
    }
    public void Spawn(Vector3 spawnTo)
    {
        Vector2 random = Random.insideUnitCircle * 10;
        transform.position = spawnTo + new Vector3(random.x, 0, random.y);
    }

    public void TakeDamage(int damage)
    {
        if (_healh > 0)
        {
            _healh -= damage;
            Animation.SetTrigger("GetDamage");
        }
        _speed = _speed / 2;
       
        ActionEventGoneDove.EventOnGetDamage?.Invoke();
        
        if (_healh <= 0)
        {
            isGone = true;
            ActionEventGoneDove.EventOnDoveGone?.Invoke();
        }
    }

   
}
