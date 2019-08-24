using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankService : MonoSingletonGeneric<TankService> 
{
    private TankController tankController;
    // private TankController[] tankControllers;
	public TankView tankPrefab;
    public TankScriptableObjects[] tankConfigs;

    private void Start()
    {
        int Score = PlayerPrefs.GetInt("Score", 0);
        int Lives = PlayerPrefs.GetInt("Lives", 3);
        SpawnTank();
    }
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
        // TankModel TankModel = new TankModel(TankType.None, 0.1f, 100f, 4);
        tankController = new TankController(TankModel, tankPrefab);
        
        return tankController;
    }

    public void UpdateLives()
    {
        Lives--;
        PlayerPrefs.SetInt("Lives", Lives);
    }
}
