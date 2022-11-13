using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LossArea : MonoBehaviour
{
    private int _comeDove = 0;
    public Text ComeDovesUI;
    public GameManager GameManager;

    private void Start()
    {
        ComeDovesUI.text = "Голубей откусивших бутерброд: " + _comeDove.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.attachedRigidbody && other.attachedRigidbody.GetComponent<Enemy>())
        {
            _comeDove++;
            ComeDovesUI.text = "Голубей откусивших бутерброд: " + _comeDove.ToString();

            if (_comeDove == 3)
            {
                GameManager.GameOverFall();
            }
        }
    }
}
