using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModel
{
	public BulletModel(BulletScriptableObjects bulletScriptableObject)
    {
        bulletType = bulletScriptableObject.BulletType;
        bulletDamage = bulletScriptableObject.Damage;
    }

	public BulletType bulletType { get; }
	public float bulletDamage { get; }
}
