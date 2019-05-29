using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameWinStarsScr : MonoBehaviour {

    private Image image;
    public Sprite[] sprites;


    private void Start()
    {
        image = GetComponentInChildren<Image>();
    }

    private void OnEnable()
    {
        int x = FindObjectOfType<GameHelper>().Stars;
        GetComponent<Image>().sprite = sprites[x];
    }
}
