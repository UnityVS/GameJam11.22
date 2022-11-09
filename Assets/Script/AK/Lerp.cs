using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class Lerp : MonoBehaviour
{
    public float Start = 0;
    public float Finish = 100;
    [Range(0,100)]
    public float Delta;

    public float ResultLerp;
    public float ResultMoveToLerp;

    private void Update()
    {
        ResultLerp = Mathf.Lerp(Start, Finish, Time.time);
        ResultMoveToLerp = Mathf.MoveTowards(Start, Finish, Time.time);
    }
}
