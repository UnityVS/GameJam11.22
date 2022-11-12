using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class BulletTime : MonoBehaviour
{
    [SerializeField] float _timeToForce = 2f;
    private float _currentTime;

    //private float _currentForce=1;
    //private float _force = 10;

    //public Text _textCurrentForce;
    //public Text _textForce;
    private void Update()
    {
        if (_currentTime >= 0f)
        {
            _currentTime -= Time.unscaledDeltaTime;

            //_force =Mathf.Lerp(_force,10f, Mathf.Sin(1));
            // _force = Mathf.Sin(30*0.5f+0.5f)*Time.deltaTime*100;          
        }
       

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    _currentForce = _force;
        //    _currentTime = 0.5f;
        //    _textCurrentForce.text ="Сила удара" + _currentForce.ToString();
        //}

        if (Input.GetMouseButton(0))
        {
            _currentTime = _timeToForce;    
        }
        //Debug.Log(_currentForce);
        //_textForce.text =" Диапозон силы " + _force.ToString();
        StopTime();
    }

    public void StopTime()
    {
        if (_currentTime >= 0)
        {
            Time.timeScale = 0.2f;
        }
        else if (_currentTime<=0)
        { 
            Time.timeScale = 1f;
        }       
    }


    //public void StartChangeForce()
    //{
    //    StartCoroutine(nameof(ChangeForce));
    //}


    //public IEnumerator ChangeForce()
    //{
    //    for (float i = 0; i < 1; i += 0.1f)
    //    {
    //        _force = (Mathf.Sin(i*30)*0.5f+0.5f)*10;
    //        yield return new WaitForSecondsRealtime(0.2f);
    //    }
        

    //}
}
