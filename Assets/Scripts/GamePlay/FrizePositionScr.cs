using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrizePositionScr : MonoBehaviour {

   // костыль фризящий положение лабиринта

    Transform transform;
    Vector2 pos;
	
    
	void Start () {
        transform = GetComponent<Transform>();
        pos = Vector2.zero;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = pos;
	}

    

}
