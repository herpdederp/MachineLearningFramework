using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnit
{
    void StepSimulation();
    GameObject GetGameObject();
}

public static class GlobalControl
{
    public static bool allowManualInput;
    public static bool automaticTick;

    public static uint enemiesKilled;
    public static List<IUnit> units = new List<IUnit>();

    public static List<IUnit> unitsToRemove = new List<IUnit>();

    public static void StepAll()
    {
        foreach (IUnit Unit in units)
        {
            Unit.StepSimulation();
        }

        foreach (IUnit Unit in unitsToRemove)
        {
            units.Remove(Unit);
        }

        unitsToRemove.Clear();

    }

}
