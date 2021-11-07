using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject gamePauseCanvas;
    public GameObject pauseButtonCanvas;

    private void Start()
    {
        Time.timeScale = 1;
        pauseButtonCanvas.SetActive(true);
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        pauseButtonCanvas.SetActive(false);
    }

    public void Pause()
    {
        gamePauseCanvas.SetActive(true);
        Time.timeScale = 0;
        pauseButtonCanvas.SetActive(false);
    }

    public void UnPause()
    {
        gamePauseCanvas.SetActive(false);
        Time.timeScale = 1;
        pauseButtonCanvas.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
        pauseButtonCanvas.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
