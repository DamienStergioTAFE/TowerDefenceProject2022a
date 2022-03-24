using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Monobehaviour is the base class from which ALL unitu scripts inherit from. Start() and Update() are there because of Monobehaviour.
/// We are making a Scriptable Object here and will not need that functionality.
/// 
/// </summary>

[CreateAssetMenu]
public class CreepSO : ScriptableObject
{
    public float maxHealth;
    public float speed;
    public float armour;
    public float money;
}
