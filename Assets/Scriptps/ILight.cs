using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILight : MonoBehaviour
{

    public GameObject redlight;
    public GameObject greenlight;

    private void Start()
    {
        redlight.SetActive(true);
         greenlight.SetActive(false);
    }
    private void OnEnable()
    {
        InputActions.JumpEventStarted += Turnon;
        InputActions.JumpEventPreformed += Duration;
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
        greenlight.SetActive(true);
        redlight.SetActive(false);

    }

    private void Turnoff()
    {
        redlight.SetActive(true);
        greenlight.SetActive(false);

    }

    private void Duration()
    {

    }
}
