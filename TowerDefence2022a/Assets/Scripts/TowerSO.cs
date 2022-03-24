using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Tower template", menuName = "New Tower")]
public class TowerSO : ScriptableObject
{
    public float range = 5;
    public float damage = 1;
    public float fireRate = 1;
    public float price = 1;
    public TowerSO upgrade;
    
}
