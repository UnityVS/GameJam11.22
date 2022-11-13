using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject WinImage;
    public GameObject FallImage;
    public void GameOverWin()
    {
        Time.timeScale = 0.1f;
        WinImage.SetActive(true);
    }

    public void GameOverFall()
    {
        Time.timeScale = 0.1f;
        FallImage.SetActive(true);
    }
}
