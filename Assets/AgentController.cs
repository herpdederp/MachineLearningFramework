using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour
{

    bool right;

    // Use this for initialization
    void Start()
    {
        Invoke("SwapDirection", 3.0f);
    }

    void SwapDirection()
    {
        right = !right;

        Invoke("SwapDirection", 3.0f);
    }

    // Update is called once per frame
    void Update()
    {

        if (right)
            transform.Translate(Vector3.left * Time.deltaTime * 5f);
        else transform.Translate(Vector3.right * Time.deltaTime * 5f);
    }
}
