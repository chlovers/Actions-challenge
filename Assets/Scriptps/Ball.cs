using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody rb;     // settin the speed , ridgibody and movement 
    public Vector3 movement;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        InputActions.JumpEventStarted += rollball; //subbing to actions and getting rididbody
        InputActions.JumpEventCancled += stopball;  
        rb = this.GetComponent<Rigidbody>();
    }
    private void OnDisable()
    {
        InputActions.JumpEventStarted -= rollball;
        InputActions.JumpEventCancled -= stopball;  // unsubbing to actions 

    }
      
    private void rollball()
    {
        rb.velocity = Vector3.right *speed ;   // move right whdn space is pressed 

    }
    private void stopball()
    {
        rb.velocity = Vector3.left * speed; // move left when space is let go
    }

}
