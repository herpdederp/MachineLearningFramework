using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentController : MonoBehaviour, IUnit
{
    uint health = 10;

    uint framesUntilSwapDirection;

    bool right;


    void ApplyDamage(uint damageAmount)
    {
        health -= damageAmount;

        if (health <= 0)
        {
            GlobalControl.units.Remove(this);
            GlobalControl.enemiesKilled++;
            Destroy(gameObject);

        }
    }

    // Use this for initialization
    void Start()
    {
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
            transform.Translate(Vector3.left * 0.1f);
        else transform.Translate(Vector3.right * 0.1f);
    }


}
