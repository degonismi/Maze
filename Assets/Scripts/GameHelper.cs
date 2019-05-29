using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {

    //управление игровым процессом

    public GameObject gamePanel;
    public GameObject pausePanel;
    public GameObject diePanel;
    public GameObject winPanel;

    public int Stars;


    public void PauseButton()
    {
        Time.timeScale = 0.0f;
        gamePanel.SetActive(false);
        pausePanel.SetActive(true);

    }

    public void ResumeButton()
    {
        Time.timeScale = 1.0f;
        gamePanel.SetActive(true);
        pausePanel.SetActive(false);
    }

    public void RestartButton()
    {
        TimerScr.timer = 0.0f;
        Time.timeScale = 1.0f;
        GameManager.ChangeSceneToGame(GameManager.currentScene);
    }

    public void NextLevel()
    {
        Time.timeScale = 1.0f;
        GameManager.ChangeSceneToNext();

    }

    public void WinLevel()
    {
        gamePanel.SetActive(false);
        winPanel.SetActive(true);
        GameManager.LevelComplited(Stars);
        GameManager.AdsCheck();


    }

    public void LoseLevel()
    {
        gamePanel.SetActive(false);
        diePanel.SetActive(true);
        GameManager.AdsCheck();
    }
    
    

    public void MenuButton()
    {
        TimerScr.timer = 0.0f;
        Time.timeScale = 1.0f;
        GameManager.ExitToMenu();
        GameManager.AdsCheck();
    }



}
