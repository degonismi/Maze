using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHelper : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Add");
        Destroy(this.gameObject);
    }
}
