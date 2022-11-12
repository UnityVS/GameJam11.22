using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private float _maxSpeed = 4f, _minSpeed = 2f;
    private int _maxHealth = 2, _minHealth = 3;

    public List<Enemy> Enemylist;

    public bool CheckListOnNullForSpawnManager = false;


    
    public void CraeteEnemyFromList()
    {
        if (Enemylist.Count >= 1)
        {
            Create(Enemylist[0]);
           
        }
        
    }
    public void Create(Enemy enemy)
    {
        Enemy newEnemy = Instantiate(enemy);
        newEnemy.Initialization(Random.Range(_maxSpeed, _minSpeed), Random.Range(_maxHealth, _minHealth));
        newEnemy.Spawn(transform.position);    
    }
    public void DeleteFromList()
    {

        Enemylist.RemoveAt(0);
        if (Enemylist.Count == 0)
        {
            CheckListOnNullForSpawnManager = true;
        }
    }

    
    
}
