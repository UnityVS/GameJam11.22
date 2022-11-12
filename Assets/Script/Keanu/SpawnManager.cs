using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour
{
    public List<Spawn> SpawnList;
    public int ValueDoves;
    private int _createdSpawnCountAtStart;
    public GameManager GameManager;
    public Text ValueDovesUi;

    private void Start()
    {
        ActionEventGoneDove.EventOnDoveGone += DeleteDoveFromList;
        ActionEventGoneDove.EventOnDoveGone += ValueDovesStay;
        _createdSpawnCountAtStart = SpawnList.Count;
        for (int i = 0; i < SpawnList.Count; i++)
        {
            SpawnList[i].CraeteEnemyFromList();
            ValueDoves += SpawnList[i].Enemylist.Count;
        }
       
        Debug.Log(ValueDoves);
        ValueDovesUi.text ="Осталось голубей " +  ValueDoves.ToString();
    }
   
    public void DeleteDoveFromList()
    {
        if (ValueDoves == _createdSpawnCountAtStart)
        {
            ActionEventGoneDove.EventOnDoveGone -= DeleteDoveFromList;
            return;
        }

        SpawnList[Random.Range(0, SpawnList.Count)].DeleteFromList();
       
        
        for (int t = 0; t < SpawnList.Count; t++)
        {
            if (SpawnList[t].CheckListOnNullForSpawnManager == true)
            {
                SpawnList.RemoveAt(t);             
            }
            
        }
        if (SpawnList.Count > 0)
        {
            SpawnList[Random.Range(0, SpawnList.Count)].CraeteEnemyFromList();
        }
        
    }
    public void ValueDovesStay()
    {
        ValueDoves--;
        ValueDovesUi.text = "Осталось голубей " + ValueDoves.ToString();
        if (ValueDoves == 0)
        {
            ActionEventGoneDove.EventOnDoveGone -= ValueDovesStay;
            GameManager.GameOverWin();

        }
    }
}
