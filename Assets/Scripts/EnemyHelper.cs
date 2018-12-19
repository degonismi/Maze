using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHelper : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            Debug.Log("Att");
            Destroy(this.gameObject);
        }
    }
}
