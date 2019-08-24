﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{

    private BulletController bulletController;
	public TankController(TankModel model, TankView prefab)
	{
		tankModel = model;
		tankView = GameObject.Instantiate<TankView>(prefab);

        //X location where new tank is spawned
        Debug.Log("Tank type -" + model.tankType);
		tankView.Init(this);
		//tankView.SetTankPos(4);
	}
	
	public void FireBullet()
	{	
		Vector3 position = tankView.transform.position + new Vector3(0f , 1f , 1f);
		bulletController = BulletService.Instance.SpawnBullet();
		bulletController.SetBulletPostion(position);
	}

	public void ApplyDamage(float damage)
	{
		tankModel.Health -= damage;

		if(tankModel.Health <= 0)
		{
			TankService.Instance.UpdateLives();
		}
	}
	public TankModel tankModel { get; }
	public TankView tankView { get; } 
}
