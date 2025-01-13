using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 20.0f;
    public Rigidbody rb;
    public Vector3 movement;

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        InputActions.JumpEventStarted += rollball;
        InputActions.JumpEventCancled += stopball;
        rb = this.GetComponent<Rigidbody>();
    }
    private void OnDisable()
    {
        InputActions.JumpEventStarted -= rollball;
        InputActions.JumpEventCancled -= stopball;

    }
      
    private void rollball()
    {
        rb.velocity = Vector3.right *speed ; 

    }
    private void stopball()
    {
        rb.velocity = Vector3.left * speed;
    }

}
