using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeControl : MonoBehaviour
{
    public GameObject Bridge;

    private void OnEnable()
    {
        InputActions.BridgeUp += moveup;
        InputActions.BridgeDown += movedown;
    }

    private void OnDisable()
    {
        InputActions.BridgeUp -= moveup;
        InputActions.BridgeDown -= movedown;
    }

    private void moveup()
    {
        Bridge.transform.position = new Vector3(Bridge.transform.position.x, Bridge.transform.position.y + 1, Bridge.transform.position.z);
    }

    private void movedown()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y- 1, transform.position.z);
    }

}
