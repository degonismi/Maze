using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonMenuLangScr : MonoBehaviour {

    public Sprite _0,
                  _1;

    public string ParamsForButtonSprite;
    private Image sprite;

    private void Start()
    {
        sprite = GetComponent<Image>();
    }

    void Update () {
        if (PlayerPrefs.GetInt(ParamsForButtonSprite) == 0)
        {
            sprite.sprite = _0;
        }
        if (PlayerPrefs.GetInt(ParamsForButtonSprite) == 1)
        {
            sprite.sprite = _1;
        }
    }
}
