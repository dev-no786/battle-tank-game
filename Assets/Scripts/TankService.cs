using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService> 
{

	public TankView tankPrefab;
	void Start () {
		
	}

    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            print("Tank Spawned");
            SpawnTank();
        }
    }

    private TankController SpawnTank()
    {
        //Instantiate(tankPrefab, new Vector3(6 , 3 , 0), Quaternion.identity);
        TankModel TankModel = new TankModel(TankType.None, 0.1f, 100f, 4);
        TankController TankController = new TankController(TankModel, tankPrefab);
        return TankController;
    }
}
