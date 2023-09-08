using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "New Champion", menuName = "Champion")]
public class Creature : ScriptableObject
{
    public class Champion
    {



        public Sprite champPicture;
        public string champName;

        public double Attack;
        public double Defense;
        public double SpAttack;
        public double SpDefense;
        public double Health;
        public double Speed;
    }



}
   

