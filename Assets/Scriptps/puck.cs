using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puck : MonoBehaviour
{
    public Transform Start;
    public Transform InGoal;

    public float speed = 2f;

    private Transform targetPoint;
    private bool isMoving = false;

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space) && !isMoving)
        {
            isMoving = true;
            targetPoint = (targetPoint == Start) ? InGoal : Start;
        }

       if (isMoving)
        {
            MovePuck();
        }

    }

    void MovePuck()
    {

        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, targetPoint.position, step);


        if (transform.position == targetPoint.position)
        {
            isMoving = false;
        }
    }

}
