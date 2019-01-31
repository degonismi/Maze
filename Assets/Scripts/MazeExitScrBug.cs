using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeExitScrBug : MonoBehaviour {

    // если лабиринт  пройден  не правильно

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            Debug.Log("Bug");
        }
    }
}
