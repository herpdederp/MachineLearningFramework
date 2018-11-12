using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IUnit
{
    public GameObject shot;

    bool turnLeft;
    bool turnRight;
    bool moveRight;
    bool moveForward;
    bool moveLeft;

    CharacterController characterController;

    int numberOfHits;


    public Transform target;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        GlobalControl.units.Add(this);
    }

    private void Update()
    {
        if (GlobalControl.allowManualInput)
        {
            if (Input.GetKey(KeyCode.E))
            {
                TurnLeft();
            }
            else if (Input.GetKey(KeyCode.Q))
            {
                TurnRight();
            }
            else StopTurn();

            if (Input.GetKey(KeyCode.A))
            {
                MoveLeft();
            }
            else if (Input.GetKey(KeyCode.W))
            {
                MoveForward();
            }
            else if (Input.GetKey(KeyCode.D))
            {
                MoveRight();
            }
            else StopMove();

            if (Input.GetKeyDown(KeyCode.F))
            {
                ShootInDirection(transform.forward);
            }
        }

    }

    void StopTurn()
    {
        turnLeft = false;
        turnRight = false;
    }

    void TurnLeft()
    {
        turnLeft = true;
        turnRight = false;
    }

    void TurnRight()
    {
        turnLeft = false;
        turnRight = true;
    }

    void StopMove()
    {
        moveRight = false;
        moveForward = false;
        moveLeft = false;
    }

    void MoveForward()
    {
        moveRight = false;
        moveForward = true;
        moveLeft = false;
    }

    void MoveRight()
    {
        moveRight = true;
        moveForward = false;
        moveLeft = false;
    }

    void MoveLeft()
    {
        moveRight = false;
        moveForward = false;
        moveLeft = true;
    }

    int GetNumberOfHits()
    {
        return numberOfHits;
    }

    Vector3 GetDirectionOfNearestTarget()
    {
        target = null;

        foreach (IUnit Unit in GlobalControl.units)
        {
            if (Unit.GetGameObject().GetComponent<AgentController>() == true)
            {
                if (Vector3.Distance(Unit.GetGameObject().transform.position, transform.position) < (Vector3.Distance(Unit.GetGameObject().transform.position, target.position)))
                {
                    target = Unit.GetGameObject().transform;
                }
            }
        }

        return (transform.position - target.position);
    }

    void ShootInDirection(Vector3 direction)
    {
        GameObject.Instantiate(shot, transform.position, Quaternion.Euler(direction));
    }

    public void StepSimulation()
    {
        if (moveRight == true)
            characterController.Move(transform.right * 0.1f);
        else if (moveForward == true)
            characterController.Move(transform.forward * 0.1f);
        else if (moveLeft == true)
            characterController.Move(transform.right * -0.1f);

        if (turnLeft == true)
            transform.Rotate(Vector3.up);
        else if (turnRight == true)
            transform.Rotate(Vector3.down);
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }


}
