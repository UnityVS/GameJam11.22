using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuManager : MonoBehaviour
{

    [SerializeField] private GameObject Menu;
    [SerializeField] private GameObject ButtonPause;

    [SerializeField] private AudioSource MusicInGame;

    [SerializeField] List<MonoBehaviour> ScriptList = new List<MonoBehaviour>();
   public void MenuActivated()
    {
        foreach (MonoBehaviour script in ScriptList)
        {
            script.enabled = false;
        }
        Menu.SetActive(true);
        
        Time.timeScale = 0.02f;
    }

    public void MenuDeactivated()
    {
        Menu.SetActive(false);
        ButtonPause.SetActive(true);
        foreach (MonoBehaviour script in ScriptList)
        {
            script.enabled = true;
        }
        Time.timeScale = 1f;
    }

    public void MusicOff(bool value)
    {
        if (value == false)
        {
            MusicInGame.Pause();
        }
        else
        {
            MusicInGame.Play();

        }
        
    }

    public void MusicVolume(float Value)
    {
        AudioListener.volume = Value;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
