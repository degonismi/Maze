using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuHelper : MonoBehaviour {

    public GameObject startPanel;
    public GameObject levelsPanel;

    public void ChangeScene(int x)
    {
        GameManager.ChangeSceneToGame(x);
    }

}
