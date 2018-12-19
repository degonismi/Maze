using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeExitScr : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Debug.Log("You win");
        }
    }
}
