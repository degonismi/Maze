using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuTextScr : MonoBehaviour {

    public Text Play,
                Info;
    private GameLangScr langScr;

    private void Awake()
    {
        langScr = FindObjectOfType<GameLangScr>();
    }

    private void Start()
    {
        Play.text = langScr.Menu_play;
        Info.text = langScr.Menu_info;
    }

    public void Refresh()
    {
        Play.text = langScr.Menu_play;
        Info.text = langScr.Menu_info;
    }
}
