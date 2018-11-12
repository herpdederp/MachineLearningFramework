using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour, IUnit
{
    public void Start()
    {
        GlobalControl.units.Add(this);
    }

    public void StepSimulation()
    {
        transform.Translate(transform.forward * 0.1f);

        foreach (IUnit Unit in GlobalControl.units)
        {
            if (Unit.GetGameObject().GetComponent<AgentController>() == true)
            {
                if (Vector3.Distance(Unit.GetGameObject().transform.position, transform.position) < 1.0f)
                {
                    Unit.GetGameObject().GetComponent<AgentController>().ApplyDamage(5);

                    GlobalControl.unitsToRemove.Add(this);
                    Destroy(gameObject);
                }
            }
        }

    }
    public GameObject GetGameObject()
    {
        return gameObject;
    }
}
