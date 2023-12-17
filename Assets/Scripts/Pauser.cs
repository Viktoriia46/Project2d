using System;
using UnityEngine;

public class Pauser : MonoBehaviour
{
    public GameObject PauseWindow;

    private void Start()
    {
        Resume();
    }

    public void Pause()
    {
        PauseWindow.SetActive(true);
        Time.timeScale = 0;
    }
    
    public void Resume()
    {
        PauseWindow.SetActive(false);
        Time.timeScale = 1;
    }
}