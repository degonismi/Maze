using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeMover : MonoBehaviour {


    public float torque;
    public Rigidbody2D rb;

    private float speed = 10.0f;

    Vector2 lastDirection;
    Vector2 direction;

    public GameObject touchpad;
    public TouchInputPanel touchHelper;

    private float turn;

    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        torque = 30.0f;

        touchHelper = touchpad.GetComponent<TouchInputPanel>();

        lastDirection = Vector2.zero;
    }

    void Update()
    {
        //turn = Input.GetAxis("Horizontal");




        direction = touchHelper.GetDirectionFromTouch();

       

            if (direction != lastDirection)
                rb.AddTorque(direction.x * 15);
            
                //lastDirection = direction;
                
        //rb.angularVelocity = rb.angularVelocity + turn * 0.1f;

        lastDirection = direction;


        
    }

    private void MoveTheMaze()
    {

    }

    /*void FixedUpdate()
    //    {

            direction = touchPad.GetDirectionFromTouch();

            if (direction != lastDirection)
                rigidbody.velocity = new Vector3(direction.x, direction.y, 0.0f) * speed * Time.deltaTime;
            else
            {
                //rigidbody.velocity = Vector3.Lerp(direction, direction, 0.001f * Time.deltaTime );
            }
            lastDirection = direction;


            rb.AddTorque(torque * turn, ForceMode2D.Force);
        //rb.angularVelocity = rb.angularVelocity + turn * 0.1f;

*/



}
