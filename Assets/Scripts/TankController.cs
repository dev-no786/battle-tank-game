using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController
{

	public TankController(TankModel model, TankView prefab)
	{
		tankModel = model;
		tankView = GameObject.Instantiate<TankView>(prefab);

        //X location where new tank is spawned
        tankView.SpawnTankHere(4);
	}
	
	public TankModel tankModel { get; }
	public TankView tankView { get; } 
}
