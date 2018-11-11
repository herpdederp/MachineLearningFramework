using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    void StepSimulation();
}

public static class GlobalControl
{
    public static uint enemiesKilled;
    public static List<IUnit> units = new List<IUnit>();

    public static void StepAll()
    {
        foreach (IUnit Unit in units)
        {
            Unit.StepSimulation();
        }
    }

}
