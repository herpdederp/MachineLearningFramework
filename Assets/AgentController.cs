using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour, IUnit
{
    CharacterController characterController;

    uint health = 10;

    uint framesUntilSwapDirection;

    bool right;


    public void ApplyDamage(uint damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            GlobalControl.unitsToRemove.Add(this);
            GlobalControl.enemiesKilled++;
            Destroy(gameObject);

        }
    }

    // Use this for initialization
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        GlobalControl.units.Add(this);
        framesUntilSwapDirection = 90;
    }

    void SwapDirection()
    {
        right = !right;

        framesUntilSwapDirection = 90;
    }


    public void StepSimulation()
    {

        if (framesUntilSwapDirection <= 0)
        {
            SwapDirection();
        }
        else framesUntilSwapDirection--;

        if (right)
            characterController.Move(Vector3.left * 0.1f);
        else characterController.Move(Vector3.right * 0.1f);
    }

    public GameObject GetGameObject()
    {
        return gameObject;
    }

}
