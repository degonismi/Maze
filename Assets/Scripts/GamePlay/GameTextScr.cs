using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTextScr : MonoBehaviour {

    public Text Menu,
                Restart,
                Resume,
                Next,
                Win,
                Lose,
                Pause;

    GameLangScr langScr;
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
        langScr = FindObjectOfType<GameLangScr>();


        
    }

    void Start ()
    {
        switch (gameObject.name)
        {

            case "Menu":
                {
                    _text.text = langScr.Game_menu;
                    break;
                }

            case "Restart":
                {
                    _text.text = langScr.Game_restart;
                    break;
                }
            case "Resume":
                {
                    _text.text = langScr.Game_resume;
                    break;
                }
            case "Next":
                {
                    _text.text = langScr.Game_next;
                    break;
                }
                case "Pause":
                {
                    _text.text = langScr.Game_pause;
                    break;
                }

        }
    }
	

	void Update () {
		
	}
}
