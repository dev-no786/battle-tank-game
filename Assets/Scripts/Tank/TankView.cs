using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour, IDamageable
{

    public TankType tankType;
	private TankController tankController;
	// Update is called once per frame

    public void TakeDamage(float damage,int tankHitId)
    {
        tankController.ApplyDamage(damage,tankHitId);
    }    
	void Update () 
    {
        Fire();
	}

    void FixedUpdate()
    {
        GetInput();
    }

    public void Init(TankController c)
    {
        this.tankController = c;
    }

    private void GetInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0.21f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }
    }

    private void Fire()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            tankController.FireBullet();
        }   
    }
    public void SetTankPos(float x)
    {
        transform.position = new Vector3 (x , 0, 0);
    }
}
