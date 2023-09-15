using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(fileName = "Champion", menuName = "Champion/Create New")] 
public class champData : ScriptableObject
{

    [SerializeField] string realName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite sprite;

    [SerializeField] champRegion region1;

    [SerializeField] champRegion region2;

    [SerializeField] champType Type1;

    [SerializeField] champType Type2;

    [SerializeField] champAbility ability;
    //Base Stats

    [SerializeField] int maxHp;

    [SerializeField] int Attack;

    [SerializeField] int abilityPower;

    [SerializeField] int Armor;

    [SerializeField] int magicResist;

    [SerializeField] int Speed;

    
    



}




public enum champRegion
{

    None,
    Noxus,
    Ionia,
    Freljord,
    Demacia,
    bandleCity,
    shadowIsles,
    bilgeWater,
    Shurima,
    Ixtal,
    Piltover,
    Zaun,
    theVoid,
    Targon


}

public enum champType
{

    None,
    Normal,
    Fire,
    Water,
    Grass,
    Electric,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dark,
    Dragon,
    Steel,
    Fairy


}

public enum champAbility
{

    None,
    Ability1,
    Ability2,
    Ability3

}