using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMenuZaze : MonoBehaviour {



    
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		
	}



    public void moveLeft()
    {

        transform.Rotate(0, 0, 90);
    }
    public void moveRight()
    {

        transform.Rotate(0, 0, -90);
    }



}
