using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public string Name { get; }
    public string Type { get; }
    public int Power { get; }
    public double Accuracy { get; }
    public string Description { get; }

    public Move(string name, string type, int power, double accuracy, string description)
    {
        Name = name;
        Type = type;
        Power = power;
        Accuracy = accuracy;
        Description = description;
    }

    public virtual void Use(champions user, champions target)
    {
        // Implement logic for using the move in battle
    }
}

public class LeapStrike : Move
{
    public LeapStrike() : base("Leap Strike", "Shuriman", 40, 0.9, "leaps at an enemy")
    {

    }
}

public class Thunderbolt : Move
{
    public Thunderbolt() : base("Thunderbolt", "Electric", 90, 0.7, "A powerful electric attack.")
    {
    }
}

public class WaterGun : Move
{
    public WaterGun() : base("Water Gun", "Water", 40, 0.9, "Shoots a stream of water at the target.")
    {
    }
}

public class FirePunch : Move
{
    public FirePunch() : base("Fire Punch", "Fire", 75, 0.8, "Delivers a fiery punch.")
    {
    }
}
