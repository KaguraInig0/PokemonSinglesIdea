using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChampAbility: MonoBehaviour
{
    public string Name;

    public string Description;

}

public class AbilityA
{

    public ChampAbility abilityA;

    public AbilityA()
    {
        abilityA.Name = "SandSpeed";
        
        abilityA.Description = string.Empty;
    }


}

public class AbilityB
{

    public ChampAbility abilityB;

    public AbilityB()
    {
        abilityB.Name = "FireSpeed";

        abilityB.Description = string.Empty;
    }


}

public class AbilityC
{

    public ChampAbility abilityC;

    public AbilityC()
    {
        abilityC.Name = "WaterSpeed";

        abilityC.Description = string.Empty;
    }


}


