using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMove : MonoBehaviour {

    [SerializeField]
    private float forceForMaze;

    public GameObject Maze;

    private Rigidbody2D rb2;
    private Transform mazeTransform;
    private Vector2 mazePosition;

    private bool isTouch;
    

	
	void Start () {
        

        rb2 = Maze.GetComponent<Rigidbody2D>();
        mazeTransform = Maze.GetComponent<Transform>();


        forceForMaze = 30000.0f;
    }
	

	void Update () {
        
	}
    private void FixedUpdate()
    {
        if (Input.touchCount > 0 && isTouch)
        {

            Vector2 fpos = Input.GetTouch(0).deltaPosition;
            rb2.AddTorque(fpos.x * forceForMaze);
        }

    }

    private void OnMouseDown()
    {
        isTouch = true;
        
    }

    private void OnMouseUp()
    {
        isTouch = false;

    }
}
