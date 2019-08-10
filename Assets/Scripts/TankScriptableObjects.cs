using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TankScriptableObject", menuName = "ScriptableObject/NewTankScriptableObject")]
public class TankScriptableObjects : ScriptableObject 
{
    public TankType TankType;
    public string TankName;
    public float Speed;
    public float Health;
}
