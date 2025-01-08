using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class hud : MonoBehaviour
{
    public TextMeshProUGUI displayscore;
    private int goals;

    // Start is called before the first frame update
    void Start()
    {
        goals = 0; // setting the score to 0
    }

    private void OnEnable()
    {
        Actions.score += goal;
    }
    // sudding and unsubbin to action
    private void OnDisable()
    {
        Actions.score -= goal;
    }

    private void goal()
    {
        goals += 1;  // addin a goal when i goes in net
        displayscore.text = "Goals: " + goals;  // display the score
    }
}