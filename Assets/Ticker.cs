using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour
{

    private void Start()
    {
        GlobalControl.allowManualInput = true;
        GlobalControl.automaticTick = true;
    }

    private void FixedUpdate()
    {
        if (GlobalControl.automaticTick == true)
            GlobalControl.StepAll();
    }
}
