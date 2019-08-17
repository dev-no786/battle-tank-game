using System.Collections;
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
        Debug.Log("Tank type -" + tankView.tankType);
		tankView.Init(this);
		tankView.SpawnTankHere(4);
	}
	
	public void FireBullet()
	{	
		bulletController = BulletService.Instance.SpawnBullet();
		Vector3 position = tankView.transform.position + new Vector3(0f , 0f , 1f);
		bulletController.bulletView.transform.Translate(position);
	}

	public TankModel tankModel { get; }
	public TankView tankView { get; } 
}
