using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController  
{
	private TankController c;
	public BulletController (BulletModel Model, BulletView prefab)
	{
		bulletModel = Model;
		
		bulletView = GameObject.Instantiate<BulletView>(prefab);
		
	}

	public void SetBulletPostion(Vector3 pos)
	{
		bulletView.transform.position = pos;
	}
	public BulletModel bulletModel { get; }
	public BulletView bulletView { get; }
}
