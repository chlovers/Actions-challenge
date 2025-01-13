using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject backlight;

    private void OnEnable()
    {
        Actions.score += trunonlight;
        Actions.turneverythingoff += turnofflight;
    }

    // above is subsribing to the action, and below is unsubbing

    private void OnDisable()
    {
        Actions.score -= trunonlight;
        Actions.turneverythingoff -= turnofflight;
    }




    private void Start()
    {
        backlight.SetActive(false);  // starting with the light off
    }




    private void trunonlight()
    {

        backlight.SetActive(true); //starting with the liugght on
        
    }

    private void turnofflight()
    {
        backlight.SetActive(false);

    }
}
