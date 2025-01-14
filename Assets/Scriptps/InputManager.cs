using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, Controls.IGameplayActions //grabbing the inputaction script
{
    private Controls control;

    private void Awake()
    {

        control = new Controls();
        control.Gameplay.Enable();  //enabling it 
        control.Gameplay.SetCallbacks(this);

    }

    public void OnJump(InputAction.CallbackContext context)  // invoing my actions when space is pressed held and let go 
    {
        if (context.started)
        {
            InputActions.JumpEventStarted?.Invoke();
        }

        if(context.performed)
        {
            InputActions.JumpEventPreformed?.Invoke();
        }

        if (context.canceled)
        {
            InputActions.JumpEventCancled?.Invoke();
        }

    }



    public void OnUp(InputAction.CallbackContext context)   // invoking action when W is pressed
    {
        if(context.performed)
        {
            InputActions.BridgeUp?.Invoke();
        }
    }

    public void OnDown(InputAction.CallbackContext context)  // invoking action when S is pressed 
    {
        if (context.performed)
        {
            InputActions.BridgeDown?.Invoke();

        }
    }

    public void OnHonk(InputAction.CallbackContext context) // invoking action when E is pressed and let go
    {
       if (context.performed)
        {
            InputActions.Epress?.Invoke();
        }

       if (context.canceled)
        {
            InputActions.Estop?.Invoke();
        }
    }
}
