using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class GameManager : MonoBehaviour {
    
    // основа управления игрой на базе синглтона
    
    public static List<int> currentSceneList = new List<int>(); 

    private static string savedGameString;

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
        currentScene = 0;
        SceneManager.LoadScene(0, LoadSceneMode.Single);
        TimerScr.timer = 0.0f;
        
    }


    public static void ChangeSceneToGame(int x)
    {
        currentScene = x;
        SceneManager.LoadScene(currentScene, LoadSceneMode.Single);
        TimerScr.timer = 0.0f;
        Debug.Log(x);

    }
    
    public static void ChangeSceneToNext()
    {
        currentScene += 1;
        SceneManager.LoadScene( currentScene, LoadSceneMode.Single);
        TimerScr.timer = 0.0f;

    }

    public static void SaveGame()  //сохранение игры путем создания обьекта сериализуемого класса, в JSON, затем стрингой в playerPrefs
    {
        Save save  = new Save();
        save.saveGame = currentSceneList;
        

        savedGameString = JsonUtility.ToJson(save);
        PlayerPrefs.SetString("Save", savedGameString);
        Debug.Log(savedGameString);
       
    }

    public static void loadGame() //загрузка игры
    {

    }


    public static void LevelComplited(int stars)
    {

        int Level = currentScene;
      

        if (Level > currentSceneList.Count) {
            currentSceneList.Add(stars);
            SaveGame();

        }
        else {
            if (stars < currentSceneList[Level])
            {
                currentSceneList[Level] = stars;
                SaveGame();
              
            }
            
        }
        
    }

    [System.Serializable] 
    public class Save // класс для сохранения
    {
        public List<int> saveGame = new List<int>();
        public bool sounds;
        public int lang;
    }

}
