using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScr : MonoBehaviour {

   //простенький таймер

    public static float timer;
   
    int timerMin;
    int timerSec;

    Text text;

    string nowTime;

	
	void Start () {
        text = GetComponent<Text>();
        timer = 0;
    }
	
	
	void Update () {

        timer += Time.deltaTime;

     
        timerMin = (int)timer / 60;
        timerSec = (int)timer % 60;

        string timeText = timerMin + ":" + timerSec;
        text.text = timeText;

    }

    
}
