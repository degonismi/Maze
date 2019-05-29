using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHelper : MonoBehaviour {

    //управление меню

    public GameObject startPanel;
    public GameObject levelsPanel;

    public Sprite[] stars;
    
    public GameObject[] buttons;
    
    private int openLevels;

    GameLangScr langScr;

    private void Awake()
    {
        langScr = FindObjectOfType<GameLangScr>();
        startPanel.SetActive(GameManager.ShowMenu);
        levelsPanel.SetActive(!GameManager.ShowMenu);
    }

    private void Start()
    {

        

        openLevels = GameManager.currentSceneList.Count;

        for (int i = 0; i <= openLevels && i <15; i++)
        {
            if (i < openLevels) {
                buttons[i].SetActive(true);
                buttons[i].transform.GetChild(1).GetComponent<Image>().sprite = stars[GameManager.currentSceneList[i]];
            }
            else
            {
                buttons[i].SetActive(true);
                buttons[i].transform.GetChild(1).GetComponent<Image>().sprite = stars[0];
            }

        }



    }

    public void UpdateLevels()
    {
        for (int i = 0; i < openLevels; i++)
        {
            buttons[i].SetActive(true);
            buttons[i].transform.GetChild(1).GetComponent<Image>().sprite = stars[2];

        }

    }

    public void ChangeScene(int x)
    {
        GameManager.ChangeSceneToGame(x);
    }


    public void PlayButton()
    {
        startPanel.SetActive(false);
        levelsPanel.SetActive(true);
    }
    public void ReturnButton()
    {
        startPanel.SetActive(true);
        levelsPanel.SetActive(false);
    }
    public void SoundButton()
    {
        FindObjectOfType<GameManager>().ChangeSound();
    }
    public void LangButton()
    {
        langScr.ChangeLang();
    }


}
