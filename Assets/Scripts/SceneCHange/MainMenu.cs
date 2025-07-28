using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    
    public void IntroCutScene()
    {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void MainMeNu()
    {
        SceneManager.LoadSceneAsync(0);
    }

    public void endingone()
    {
        SceneManager.LoadSceneAsync(7);
    }
    
    public void endingtwo()
    {
        SceneManager.LoadSceneAsync(8);
    }
}
