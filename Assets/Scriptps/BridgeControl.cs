using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    public GameObject Bridge;

    private void OnEnable()
    {
        InputActions.BridgeUp += moveup; //subbing to actions 
        InputActions.BridgeDown += movedown;
    }

    private void OnDisable()
    {
        InputActions.BridgeUp -= moveup; //unsubbing to actions 
        InputActions.BridgeDown -= movedown;
    }

    private void moveup() // having the bridge move up when w is pressed
    {
        Bridge.transform.position = new Vector3(Bridge.transform.position.x, Bridge.transform.position.y + 1, Bridge.transform.position.z);
    }

    private void movedown() // having the bridge move down when S is pressed
    {
        transform.position = new Vector3(transform.position.x, transform.position.y- 1, transform.position.z);
    }

}
