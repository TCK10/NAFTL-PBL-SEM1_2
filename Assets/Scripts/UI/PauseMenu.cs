using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public CanvasGroup pauseCanvas;
    public CanvasGroup statsCanvas;
    private bool isPaused = false;

    void Update()
    {
        if (Input.GetButtonDown("TogglePause"))
        {
            if (isPaused) ResumeGame(); 
            else PauseGame();
        }
    }

    public void PauseGame()
    {
        isPaused = true;
        pauseCanvas.alpha = 1;
        pauseCanvas.blocksRaycasts = true; // Allow button clicks
        statsCanvas.alpha = 1;
        Time.timeScale = 0; // Freeze game
    }

    public void ResumeGame()
    {
        isPaused = false;
        pauseCanvas.alpha = 0;
        pauseCanvas.blocksRaycasts = false; // Disable clicks when hidden
        statsCanvas.alpha = 0;
        Time.timeScale = 1; // Unfreeze game
        Debug.Log("Clicked!");
    }

    public void MainMenuOpen()
    {
        Time.timeScale = 1; // Reset time before loading menu
        SceneManager.LoadScene(0); // Use LoadScene instead of LoadSceneAsync for simplicity
    }
}