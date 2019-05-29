using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AppodealAds.Unity.Api;
using AppodealAds.Unity.Common;


public class AdsScr : MonoBehaviour {

    public bool ads;

	void Start () {

        string appKey = "233875d4d49d8716a33a954fefea2dfad85f5ccef7aaa811";
        Appodeal.initialize(appKey, Appodeal.BANNER | Appodeal.INTERSTITIAL, ads);
    

    }

    

    void Update () {
		
	}


    public static void  ShowAds()
    {
        if (GameManager.ForAds > 3)
        {
            Appodeal.show(Appodeal.INTERSTITIAL);
            GameManager.ForAds = 0;

        }

    }
}
