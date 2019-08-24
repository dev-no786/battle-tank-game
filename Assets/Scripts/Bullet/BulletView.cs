using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletView : MonoBehaviour {

	public BulletType bulletType; 

	private void Update()
	{

		
	}	 

	private void FixedUpdate()
	{
        transform.Translate(Vector3.forward);
	}
}
