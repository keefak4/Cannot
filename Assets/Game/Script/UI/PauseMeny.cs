using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMeny : MonoBehaviour
{
    [SerializeField]private static bool GamePause = false;
    [SerializeField]private GameObject pauseMenyUI;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GamePause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }    
    }

    public void Pause()
    {
        pauseMenyUI.SetActive(true);
        Time.timeScale = 0;
        GamePause = true;
    }

    public void Resume()
    {
        pauseMenyUI.SetActive(false);
        Time.timeScale = 1;
        GamePause = false;
    }
    public void LoadMeny()
    {
        Debug.Log("Meny");
    }
    public void ExitGame()
    {
        Debug.Log("Exit");
    }
}
