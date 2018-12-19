using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour {

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }
    private static GameManager instance = null;


    public static int currentScene;


    private void Awake()
    {
        if (instance)
        {

            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

    }




    public static void ExitToMenu()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        
    }


    public static void ChangeSceneToGame(int x)
    {
        currentScene = x;
        SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
        TimerScr.timer = 0.0f;
        TimerScr.timerUi = 0.0f;
    }



    public static void ChangeSceneToNext()
    {
        currentScene += 1;
        SceneManager.LoadScene( currentScene, LoadSceneMode.Single);
        
    }

}
