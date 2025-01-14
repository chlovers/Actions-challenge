using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILight : MonoBehaviour
{

    public GameObject redlight;
    public GameObject greenlight;

    private void Start()
    {
        redlight.SetActive(true);  // setting the redlight on when the game starts 
         greenlight.SetActive(false); // setting it off when the game starts 
    }
    private void OnEnable()
    {
        InputActions.JumpEventStarted += Turnon;
        InputActions.JumpEventPreformed += Duration; //subbing to actions 
        InputActions.JumpEventCancled += Turnoff;
    }

    private void OnDisable()
    {
        InputActions.JumpEventStarted -= Turnon;
        InputActions.JumpEventPreformed -= Duration;
        InputActions.JumpEventCancled -= Turnoff;
    }

    private void Turnon()
    {
        greenlight.SetActive(true); // switching the lights 
        redlight.SetActive(false);

    }

    private void Turnoff()
    {
        redlight.SetActive(true); //switching them one more then when space is let go
        greenlight.SetActive(false);

    }

    private void Duration() // didnt find a use for this yet
    {

    }
}
