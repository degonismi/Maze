using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class GameManager : MonoBehaviour {
    
    // основа управления игрой на базе синглтона
    
    public static List<int> currentSceneList; 

    private static string savedGameString;

    public int Sound;
    public AudioMixer Main;

    

    public static bool ShowMenu = true;

    private static int Level;

    public static GameManager Instance
    {
        get
        {
            return instance;
        }
    }

    private static GameManager instance = null;

    [SerializeField]
    public static int currentScene;

    public static int ForAds;
   
    private void Awake()
    {
        if (instance)
        {

            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);

        if (PlayerPrefs.HasKey("Save"))
        {
            LoadGame();
        }
        else
        {
            currentSceneList = new List<int>();
            SaveGame();
        }

        if (!PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        
    }


    private void Start()
    {
        if (PlayerPrefs.GetInt("Sound") == 1)
        {
            Main.SetFloat("Volume", 0.0f);
        }
        else
        {
            Main.SetFloat("Volume", -80.0f);
        }
        ShowMenu = false;
    }

    #region Sound
    public void ChangeSound()
    {
        if(PlayerPrefs.GetInt("Sound") == 1)
        {
            PlayerPrefs.SetInt("Sound", 0);
        }

        else
        {
            PlayerPrefs.SetInt("Sound", 1);
        }


        int x = PlayerPrefs.GetInt("Sound");


        if (x == 1)
        {
            Main.SetFloat("Volume", 0.0f);
        }
        else
        {
            Main.SetFloat("Volume", -80.0f);
        }

    }
    #endregion
    #region Scenes
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


    public static void LevelComplited(int stars)
    {

        Level = currentScene;


        if (Level > currentSceneList.Count)
        {
            currentSceneList.Add(stars);
            SaveGame();

        }
        else
        {
            int x = --Level;
            if (stars > currentSceneList[x])
            {
                
                currentSceneList[x] = stars;
                SaveGame();

            }

        }

    }

    #endregion
    #region Save
    public static void SaveGame()  //сохранение игры путем создания обьекта сериализуемого класса, в JSON, затем стрингой в playerPrefs
    {
        Save save  = new Save();
        save.saveGame = currentSceneList;
        

        savedGameString = JsonUtility.ToJson(save);
        PlayerPrefs.SetString("Save", savedGameString);
      
       
    }

    public static void LoadGame() //загрузка игры
    {
        Save load = JsonUtility.FromJson<Save>(PlayerPrefs.GetString("Save"));
        currentSceneList = load.saveGame;

    }

    public static int GetStarsCount()
    {
        int sum = 0;

        
        for(int x = 0; x < currentSceneList.Count; x++)
        {
            sum += currentSceneList[x];
        }

        return sum;
    }

    [System.Serializable]
    public class Save // класс для сохранения
    {
        public List<int> saveGame = new List<int>();

    }

    #endregion

    public static void AdsCheck()
    {
        ForAds++;
        AdsScr.ShowAds();
    }

}
