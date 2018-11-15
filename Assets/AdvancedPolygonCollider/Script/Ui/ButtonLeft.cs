using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonLeft : MonoBehaviour {

    public GameObject startPanel;
    public GameObject levelsPanel;

	// Use this for initialization
	void Start () {
		
	}
	
    public void loadLevel(int x)
    {
        
        SceneManager.LoadScene(x);
    }

	// Update is called once per frame
	void Update () {
        
	}


    public void ifStartClicked()
    {

        startPanel.SetActive(false);
        levelsPanel.SetActive(true);

    }

}
