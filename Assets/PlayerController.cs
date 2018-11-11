using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IUnit
{
    int numberOfHits;


    public Transform target;

    private void Start()
    {
        GlobalControl.units.Add(this);
    }


    void TurnLeft()
    {

    }

    void TurnRight()
    {

    }

    void MoveForward()
    {

    }

    void MoveRight()
    {

    }

    void MoveLeft()
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

    public void StepSimulation()
    {

    }




}
