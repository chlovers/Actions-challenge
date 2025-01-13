using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour, Controls.IGameplayActions
{
    private Controls control;

    private void Awake()
    {

        control = new Controls();
        control.Gameplay.Enable();
        control.Gameplay.SetCallbacks(this);

    }

    public void OnJump(InputAction.CallbackContext context)
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



    public void OnUp(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            InputActions.BridgeUp?.Invoke();
        }
    }

    public void OnDown(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            InputActions.BridgeDown?.Invoke();

        }
    }
}
