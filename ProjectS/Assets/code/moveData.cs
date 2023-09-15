using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Move/Create new")]
public class moveData : ScriptableObject
{

    [SerializeField] string moveName;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] champType moveType;

    [SerializeField] int baseDamage;

    [SerializeField] int accuracy;

    [SerializeField] int charges;

    public string Name { get { return moveName; } }

    public string Description { get { return description; } }

    public champType MoveType { get {  return moveType; } }

    public int BaseDamage { get {  return baseDamage; } }

    public int Accuracy { get { return accuracy; } }

    public int Charges { get { return charges; } }







}
