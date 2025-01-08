using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class Actions 
{

 public static Action score; // setting the action name to score

    public static Action turneverythingoff;



    public static void innet()
    {
        score?.Invoke();  // invoking the action 

        Debug.Log("was triggered right in actions sript");
    }

  
    public static void outofnet()
    {
        turneverythingoff?.Invoke();

    }
}
