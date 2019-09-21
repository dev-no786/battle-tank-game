using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemy
{
    public class EnemyView : MonoBehaviour, IDamageable
    {

        public TankType tankType;
        private EnemyController enemyController;
        public PatrollingState patrollingState;
        public ChasingState chasingState;
        public States currentState;
        // Update is called once per frame

        void Start()
        {
            ChangeState(patrollingState);
        }
        public void TakeDamage(float damage)
        {
            enemyController.ApplyDamage(damage);
        }
        void Update()
        {
            
        }

        public void Init(EnemyController c)
        {
            this.enemyController = c;
        }

        private void Fire()
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                enemyController.FireBullet();
            }
        }
        public void SetTankPos(float x)
        {
            transform.position = new Vector3(x, 0, 0);
        }

		public void ChangeState(States newState)
        {
            if(currentState != null)
            {
                currentState.OnExitState();
            }

            currentState = newState;
            currentState.OnEnterState();
        }
    }

}
