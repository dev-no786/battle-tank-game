using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoSingletonGeneric<EventSystem> 
{
	public event Action<int,int> onDeathTrigger;
	public void DeathTrigger(int idKill,int idDeath)
	{
		if(onDeathTrigger != null)
		{
			onDeathTrigger(idKill, idDeath);
		}
	}

	public event Action<int> onBulletFire;
	public void BulletFired(int playerId)
	{
		if(onBulletFire != null)
		{
			onBulletFire(playerId);
		}
	}
}
