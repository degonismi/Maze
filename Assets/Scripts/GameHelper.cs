using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHelper : MonoBehaviour {

    public GameObject gamePanel;
    public GameObject pausePanel;
    public GameObject diePanel;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
        TimerScr.timerUi = 0.0f;
        Time.timeScale = 1.0f;
        GameManager.ChangeSceneToGame(GameManager.currentScene);
    }

    public void DieButton()
    {
        
        gamePanel.SetActive(false);
        diePanel.SetActive(true);
    }

    public void MenuButton()
    {
        TimerScr.timer = 0.0f;
        TimerScr.timerUi = 0.0f;
        Time.timeScale = 1.0f;
        GameManager.ExitToMenu();

    }
}
