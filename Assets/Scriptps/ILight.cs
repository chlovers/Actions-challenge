using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ILight : MonoBehaviour
{
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


    }

    private void Turnoff()
    {


    }

    private void Duration()
    {

    }
}
