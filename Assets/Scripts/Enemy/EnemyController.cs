using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Bullet;

namespace Enemy
{
    public class EnemyController
    {
		
        private BulletController bulletController;
        public EnemyController(TankModel model, EnemyView prefab)
        {
            tankModel = model;
            enemyView = GameObject.Instantiate<EnemyView>(prefab);

            //X location where new tank is spawned
            Debug.Log("Tank type -" + model.tankType);
            enemyView.Init(this);
            bulletController = BulletService.Instance.GetBulletController(this);

        }

        public void FireBullet()
        {

            Vector3 position = enemyView.transform.position + new Vector3(0f, 1f, 1f);
            bulletController.SetBulletPostion(position);
        }

        public void ApplyDamage(float damage)
        {
            tankModel.Health -= damage;

            if (tankModel.Health <= 0)
            {
                TankService.Instance.UpdateLives();
            }
        }
        public TankModel tankModel { get; }
        public EnemyView enemyView { get; }
    }

}
