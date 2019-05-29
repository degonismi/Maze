using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinTextScr : MonoBehaviour {

    private Text _text;
	
	void Start () {
        _text = GetComponent<Text>();
        _text.text = "" + GameManager.GetStarsCount();
	}
	
	
	void Update () {
		
	}
}
