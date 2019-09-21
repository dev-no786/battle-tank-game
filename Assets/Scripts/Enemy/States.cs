using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class States : MonoBehaviour {

	protected EnemyView enemyView;

	private void Awake()
	{
		enemyView = GetComponent<EnemyView>();
	}

	public virtual void OnEnterState() 
	{
		this.enabled = true;
	}
	public virtual void OnExitState() 
	{
		this.enabled = false;
	}

}
