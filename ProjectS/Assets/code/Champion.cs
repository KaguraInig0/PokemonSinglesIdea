using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
    public class Champion: MonoBehaviour
    {

        public static int id;
        
        public static string Name;

        public static string Description;

        public Sprite Sprite;

        public static string Region1;

        public static string Region2;

        public static string Type1;

        public static string Type2;

        public List<ChampAbility> PossibleAbilities;

        public ChampAbility SelectedAbility;

        public List<Moves> LearnableMoves;

        public List<Moves> SelectedMoves;

        public static int MaxHp;

        public static int Attack;

        public static int AbilityPower;

        public static int Armor;

        public static int MagicResist;

        public static int Speed;

        public Champion()
        {
            LearnableMoves = new List<Moves>();

            SelectedMoves = new List<Moves>(4);

           
            PossibleAbilities = new List<ChampAbility>(3);
        }

    }

    


