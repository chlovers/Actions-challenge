using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSoundEffect : MonoBehaviour
{
    public AudioSource soundeffect;

    private void OnEnable()
    {
        InputActions.Epress += honk;  //subbing to aactions 
        InputActions.Estop += nohonk;
    }

    private void OnDisable()
    {
        InputActions.Epress -= honk; // unsubbing 
        InputActions.Estop -= nohonk;
    }

    private void honk()
    {
        soundeffect.UnPause();  // unpasuing when pressing E
    }

    private void nohonk()
    {
        soundeffect.Pause();  // pause when let go
    }

    private void Awake()
    {
        soundeffect.Play();   // had to put both for it to work, kind of like queueing it up 
        soundeffect.Pause();
    }
}
