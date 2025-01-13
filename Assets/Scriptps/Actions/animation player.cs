using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationplayer : MonoBehaviour
{

    public GameObject AnimatedObject;

    private Animator ani;


    void Start()
    {
        ani = AnimatedObject.GetComponent<Animator>(); // grabbing the animator 
        ani.enabled = false; // setting it to false so it doesnt play off the start 

    }

  
    public void scored()
    {
        ani.enabled = true; // enabling the animator 


    }

    public void outside()
    {

        ani.enabled = false;  // stopping the naimator 

    }

    private void OnEnable()
    {
        Actions.score += scored;
        Actions.turneverythingoff += outside; //subbing to both actions 

    }

    private void OnDisable()
    {
        Actions.score -= scored;  // unsubbing to both 
        Actions.turneverythingoff -= outside;

    }
}
