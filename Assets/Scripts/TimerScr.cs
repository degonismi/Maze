using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScr : MonoBehaviour {

    public static float timer;
    public static float timerUi;

    int timerMin;
    int timerSec;

    Text text;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        timer = Time.time;
    }
	
	// Update is called once per frame
	void Update () {

        timer += Time.deltaTime;

        timerUi = timer;

        if(timerUi > 60 && timerUi <120)
        {
            if(timerUi > 120 && timerUi < 180)
            {
                if (timerUi > 180)
                {
                    text.text = " x : xx";
                }
                timerUi -= 120;
                text.text = "2:" + (int)timerUi;
            }
            timerUi -= 60;
            text.text = "1:" + (int)timerUi;
        }
        else
        text.text = "0:" + (int)timerUi;
	}

    private int AddMinute()
    {


        return timerMin;
    }
}
