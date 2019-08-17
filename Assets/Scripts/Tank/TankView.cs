using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour {

    public TankType tankType;
	private TankController tankController;
    public void Init(TankController c)
    {
        this.tankController = c;
    }
	// Update is called once per frame
	void Update () 
    {
        Fire();
	}

    void FixedUpdate()
    {
        GetInput();
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
        if (Input.GetKey(KeyCode.F))
        {
            tankController.FireBullet();
        }   
    }
    public void SpawnTankHere(int x)
    {
        //Used extensions to insert (X value, 0 , 0)
        transform.position.SetX(4);
    }
}
