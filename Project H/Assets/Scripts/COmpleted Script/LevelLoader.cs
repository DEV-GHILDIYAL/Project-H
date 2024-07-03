using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [Header("Menu Scene")]
    [SerializeField] GameObject loadingScreen;
    [SerializeField] GameObject mainMenu;

    [Header("Slider")]
    [SerializeField] Slider loadingSlider;

    public void LoadLevelBtn(string levelToLoad){
        mainMenu.SetActive(false);
        loadingScreen.SetActive(true);

        StartCoroutine(LoadLevelAsync(levelToLoad));
    }

    IEnumerator LoadLevelAsync(string levelToLoad){
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(levelToLoad);

        while(!loadOperation.isDone){
            float progressValue = Mathf.Clamp01(loadOperation.progress / 0.9f);
            loadingSlider.value = progressValue;
            yield return null;
        }
    }
}
