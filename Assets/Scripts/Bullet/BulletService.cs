using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletService : MonoSingletonGeneric<BulletService> 
{

	public BulletView bulletPrefab;
	public BulletScriptableObjects[] bulletConfig;
	private TankController tank;
	// Update is called once per frame
	void Update () {
		
	}
	public BulletController GetBulletController(TankController tc)
	{
		BulletScriptableObjects bulletScriptableObject = bulletConfig[0];
		BulletModel BulletModel = new BulletModel(bulletScriptableObject);
		BulletController BulletController = new BulletController(BulletModel,bulletPrefab,tc);
		return BulletController;  
	} 
	
}
