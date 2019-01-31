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
                  Game_recume;


   
    public void Changelang(int i) // 0 - rus, 1 - eng
    {
        if (i == 0)
        {
            Menu_play = rus.menu_play;
            Menu_info = rus.menu_info;
            Game_menu = rus.game_menu;
            Game_next = rus.game_next;
            Game_restart = rus.game_restart;
            Game_recume = rus.game_recume;


        }

        if (i == 1)
        {

            Menu_play = eng.menu_play;
            Menu_info = eng.menu_info;
            Game_menu = eng.game_menu;
            Game_next = eng.game_next;
            Game_restart = eng.game_restart;
            Game_recume = eng.game_recume;


        }
    }
}
