using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour {

	float damage = 25.0f;
	public BulletType bulletType; 
	private int playerId;
	protected TankController tc;
	private void OnCollisionEnter(Collision collision)
	{
		IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
		if(damage != null)
		{
			tc = collision.gameObject.GetComponent<TankController>();
			
			playerId = tc.tankModel.PlayerId;
			damageable.TakeDamage(damage,playerId);
		}

	}	 

	
	private void FixedUpdate()
	{
        transform.Translate(Vector3.forward);
	}

}
