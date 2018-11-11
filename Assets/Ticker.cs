using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ticker : MonoBehaviour
{

    private void FixedUpdate()
    {
        GlobalControl.StepAll();
    }
}
