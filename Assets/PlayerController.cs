using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int numberOfHits;


    public Transform target;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    int GetNumberOfHits()
    {
        return numberOfHits;
    }

    Vector3 GetDirectionOfNearestTarget()
    {
        return (transform.position - target.position);
    }

    void ShootInDirection(Vector3 direction)
    {

    }




}
