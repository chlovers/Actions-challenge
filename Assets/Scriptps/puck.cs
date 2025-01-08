using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puck : MonoBehaviour
{
    public Transform Start;
    public Transform InGoal;  //assigning 2 points for the puck to move between 

    public float speed = 2f;  // the speed that it will move, 2 is kind of slow but can be changed in unity cause its public. 

    private Transform targetPoint;
    private bool isMoving = false;  // a bool to track if its moving or not.

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && !isMoving)  // if u press spcae and the puck is not currently moving, it sets it to moving 
        {
            isMoving = true;
            targetPoint = (targetPoint == Start) ? InGoal : Start;
        }

       if (isMoving)
        {
            MovePuck(); // if the puck is set to moving call apon move puck
        }

    }

    void MovePuck()
    {

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);  // moves the puck between the points


        if (transform.position == targetPoint.position)  // once the puck reaches the opposite point of which it started moving it sets the bool to false
        {
            isMoving = false;
        }
    }

}
