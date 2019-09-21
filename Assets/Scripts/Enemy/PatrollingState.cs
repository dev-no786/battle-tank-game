using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrollingState : States {

	protected override void Awake()
	{
		base.Awake();

	}
	public override void OnEnterState()
	{
		base.OnEnterState();
		enemyView.ResumePatrol();
	}

	public override void OnExitState()
	{
		base.OnExitState();
	}

	private void OnCollisionEnter(Collision collision)
	{
		enemyView.ChangeState(enemyView.chasingState);
	}
}