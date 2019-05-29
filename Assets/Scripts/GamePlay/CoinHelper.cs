using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinHelper : MonoBehaviour {
  
    // начисление звезд в уровне

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.name == "Ball") 
        {
            GameObject.FindObjectOfType<GameHelper>().Stars++;

            Destroy(this.gameObject);

        }

    }
}
