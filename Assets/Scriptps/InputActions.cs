using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputActions 
{

    public static Action JumpEventStarted;  //when space is pressed

    public static Action JumpEventPreformed; // after space is pressed

    public static Action JumpEventCancled; // when space is let go 

    public static Action BridgeUp; // pressing W

    public static Action BridgeDown; // pressing S

    public static Action Epress; // pressing E
    public static Action Estop; // letting go of E
}
