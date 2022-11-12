using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject WinImage;
  public void GameOverWin()
    {
        Time.timeScale = 0.1f;
        WinImage.SetActive(true);


    }
}
