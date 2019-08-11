using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService> 
{

	public TankView tankPrefab;
    public TankScriptableObjects[] tankConfigs;
    private void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            print("Tank Spawned");
            SpawnTank();
        }
    }

    private TankController SpawnTank()
    {
        TankScriptableObjects tankScriptableObject = tankConfigs[1];
        TankModel TankModel = new TankModel(tankScriptableObject);
        //TankModel TankModel = new TankModel(TankType.None, 0.1f, 100f, 4);
        TankController TankController = new TankController(TankModel, tankPrefab);
        return TankController;
    }
}
