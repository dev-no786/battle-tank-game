using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObject/NewBlulletScriptableObject")]
public class BulletScriptableObjects : ScriptableObject 
{

    public BulletType BulletType;
    public float Damage;
}
