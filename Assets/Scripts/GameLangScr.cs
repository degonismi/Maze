using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLangScr : MonoBehaviour {

    // скрипт для локализации

    
    public LangScr rus;
    public LangScr eng;

   
    public string Menu_play,
                         Menu_info,
                         Game_menu,
                         Game_next,
                         Game_restart,
                         Game_resume,
                         Game_pause;
        
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Lang"))
        {
            SelectText(PlayerPrefs.GetInt("Lang"));
        }
        else
        {
            SelectText(0);
            PlayerPrefs.SetInt("Lang", 0);

        }
    }

    public void SelectText(int i) // 0 - eng, 1 - rus
    {
        PlayerPrefs.SetInt("Lang", i);

        if (i == 0)
        {
            Menu_play = eng.menu_play;
            Menu_info = eng.menu_info;
            Game_menu = eng.game_menu;
            Game_next = eng.game_next;
            Game_restart = eng.game_restart;
            Game_resume = eng.game_resume;
            Game_pause = eng.game_pause;

        }

        if (i == 1)
        {

            Menu_play = rus.menu_play;
            Menu_info = rus.menu_info;
            Game_menu = rus.game_menu;
            Game_next = rus.game_next;
            Game_restart = rus.game_restart;
            Game_resume = rus.game_resume;
            Game_pause = rus.game_pause;

        }

        if (FindObjectOfType<MenuTextScr>() != null)
            FindObjectOfType<MenuTextScr>().Refresh();
    }

    public void ChangeLang()
    {
        int x = PlayerPrefs.GetInt("Lang");
        if (x == 0)
        {
            x = 1;
        }
        else
        {
            x = 0;
        }

        SelectText(x);
    }

}
