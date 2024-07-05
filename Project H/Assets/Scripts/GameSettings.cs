using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    public int targetFPS = 60; // Change this to your desired target FPS

    void Awake()
    {
        QualitySettings.vSyncCount = 0; // Disable VSync
        Application.targetFrameRate = targetFPS; // Set target FPS

        // Make the GameObject persistent across scenes
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        if (Application.targetFrameRate != targetFPS)
        {
            Application.targetFrameRate = targetFPS; // Ensure target FPS is maintained
        }
    }
}
