using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "Champion", menuName = "Champion/Create new Champion")]

public class Creature : ScriptableObject
{
    [SerializeField] string champName;

    [TextArea]
    [SerializeField] string descripton;

    [SerializeField] Sprite champPicture;

    [SerializeField] champType type1;
    [SerializeField] champType type2;

    //BaseStats
    [SerializeField] int Hp;
    [SerializeField] int attackDamage;
    [SerializeField] int armor;
    [SerializeField] int abilityPower;
    [SerializeField] int magicResist;
    [SerializeField] int speed;
}
   

public enum champType
{
    None,
    Ionia,
    Noxus,
    Freljord,
    Demacia,
    Bilgewater,
    PiltoverZaun,
    ShadowIsles,
    Shurima,
    Targon,
    BandleCity,
}

