using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class WaveSO : ScriptableObject
{
    public List<CreepSO> creeps;
    public List<float> spacing;
}
