using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController  
{
	private TankController tankController;
	public BulletController (BulletModel Model, BulletView prefab,TankController c)
	{
		bulletModel = Model;
		
		bulletView = GameObject.Instantiate<BulletView>(prefab);
		this.tankController = c;
	}

	public void SetBulletPostion(Vector3 pos)
	{
		bulletView.transform.position = pos;
	}
	public BulletModel bulletModel { get; }
	public BulletView bulletView { get; }
}
