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
        Debug.Log("Tank type -" + model.tankType);
		tankView.Init(this);
		bulletController = BulletService.Instance.GetBulletController(this);
		//tankView.SetTankPos(4);
	}
	
	private void Start()
	{
		EventSystem.Instance.onBulletFire += FireBullet(tankModel.PlayerId);
	}
	public void FireBullet(int playerId)
	{	
		if(this.tankModel.PlayerId == playerId)
		{
			Debug.Log("You fired a bullet");
		}
		else
		{
			Debug.Log("Player "+playerId+" fired a bullet");
		}
		Vector3 position = tankView.transform.position + new Vector3(0f , 1f , 1f);
		bulletController.SetBulletPostion(position);
	}

	public void ApplyDamage(float damage,int tankId)
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
