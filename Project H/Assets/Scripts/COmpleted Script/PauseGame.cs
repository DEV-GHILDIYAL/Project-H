using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseUI;

    public bool isPaused;

    private void Start()
    {
        Time.timeScale = 1.0f;
        isPaused = false;
    }
    public void pauseAndResume(){
        if(!isPaused){
            pauseUI.SetActive(true);
            Time.timeScale = 0;
            isPaused = true;
        }
        else{
            pauseUI.SetActive(false);
            Time.timeScale = 1;
            isPaused = false;
        }
    }
}
