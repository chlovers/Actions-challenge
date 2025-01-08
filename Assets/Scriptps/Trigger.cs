using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // checking if the tag is player
        {
           Debug.Log("was triggered properly in trigger script");
            
            Actions.innet(); // when the puck enters the net 

            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            Actions.turneverythingoff(); // so the light/particels turns off

        }

    }


}
