using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moves: MonoBehaviour 
{
    public string Name;

    public string Description;

    public string MoveType;

    public int BaseDamage;

    public int Accuracy;

    public int Charges;


}

public class MoveA
{
    public Moves moveA;

    public MoveA()
    {
        moveA = new Moves();
        
        moveA.Name = "Dream";
        
        moveA.Description = string.Empty;
        
        moveA.MoveType = "Psychic";
        
        moveA.Accuracy = 90;
        
        moveA.Charges = 0;
    }

}

public class MoveB
{
    public Moves moveB;

    public MoveB()
    {
        moveB = new Moves();

        moveB.Name = "Bubble";
        
        moveB.Description = string.Empty;

        moveB.MoveType = "Water";

        moveB.Accuracy = 100;

        moveB.Charges = 0;


    }
}

public class MoveC
{
    public Moves moveC;

    public MoveC()
    {
        moveC = new Moves();

        moveC.Name = "Leaf";

        moveC.Description = string.Empty;

        moveC.MoveType = "Grass";

        moveC.Accuracy = 100;

        moveC.Charges = 0;
    }
}

public class MoveD
{
    public Moves moveD;

    public MoveD()
    {
        moveD = new Moves();

        moveD.Name = "Flame";

        moveD.Description = string.Empty;

        moveD.MoveType = "Fire";

        moveD.Accuracy = 100;

        moveD.Charges = 0;
    }
}