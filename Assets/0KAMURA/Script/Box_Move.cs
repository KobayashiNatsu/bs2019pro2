using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box_Move : MonoBehaviour {
    bool BELT_ON_R,BELT_ON_L;
    Rigidbody RB_BOX;
    public float BELT_SPEED;
    Vector3 MOVE_R,MOVE_L;
	// Use this for initialization
	void Start () {
        MOVE_R = new Vector3(1, 0, 0);
        MOVE_L = new Vector3(-1, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (BELT_ON_R)
        {
            RB_BOX.AddForce(MOVE_R * BELT_SPEED * Time.deltaTime);
        }
        if (BELT_ON_L)
        {
            RB_BOX.AddForce(MOVE_L * BELT_SPEED * Time.deltaTime);
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "BeltConveyorR")
        {
            BELT_ON_R = true;
        }
        if (gameObject.tag == "BeltConveyorL")
        {
            BELT_ON_L = true;
        }
    }
}
