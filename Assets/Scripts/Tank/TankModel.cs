using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankModel 
{

    public TankModel(TankScriptableObjects tankScriptableObject)
    {
        tankType = tankScriptableObject.TankType;
        Speed = tankScriptableObject.Speed;
        Health = tankScriptableObject.Health;
    }
	public TankModel(TankType type,float speed, float health, int spawnspot)
	{
        tankType = type;
        Speed = speed;
        Health = health;
        Spawnspot = spawnspot;
	}

    public float Speed { get; }
    public float Health { get; }
    public int Spawnspot { get; }
    public TankType tankType { get; }
}
