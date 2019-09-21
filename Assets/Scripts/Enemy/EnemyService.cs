using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyService : MonoSingletonGeneric<EnemyService>
    {

        private EnemyController enemyController;
        public EnemyView tankPrefab;
        public TankScriptableObjects[] tankConfigs;

        private void Start()
        {
            SpawnTank();
        }
        private void Update()
        {
            
        }

        private EnemyController SpawnTank()
        {
            TankScriptableObjects tankScriptableObject = tankConfigs[1];
            TankModel TankModel = new TankModel(tankScriptableObject);
            enemyController = new EnemyController(TankModel, tankPrefab);

            return enemyController;
        }
    }

}
