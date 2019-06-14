using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour {

    ///速度の変数
    public float SPEED = 5.0f;
    public float PTURN_SPEED = 0.5f;

    ///移動関係
    Vector3 HOUKOU;
    public Rigidbody P_RB;

    public GameObject PLAYER_H;
    Player_Rotation P_MOVE;

    bool W_UP;

    public int AKUSERA_TIME;
    public float MAX_SPEED = 10f;

    Vector3 P_VECTOR;



    // Use this for initialization
    void Start () {
        P_RB = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        P_VECTOR = this.transform.position;


        //P_MOVE = PLAYER_H.GetComponent<Player_Rotation>();

        //Vector3 PV= PLAYER_H.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            if (P_RB.velocity.magnitude < MAX_SPEED)
            {
                P_RB.AddForce(this.transform.forward * SPEED * Time.deltaTime);
                W_UP = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            //P_RB.velocity = Vector3.zero;
            W_UP = true;
            AKUSERA_TIME = 0;
        }

        if (Input.GetKey(KeyCode.A))
        {
            P_RB.AddForce(this.transform.right * -SPEED * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            P_RB.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.S))
        {
            P_RB.AddForce(this.transform.forward * -SPEED * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            P_RB.velocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.D))
        {
            P_RB.AddForce(this.transform.right * SPEED * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            P_RB.velocity = Vector3.zero;
        }

        if (W_UP == true && AKUSERA_TIME < 11)
        {
            P_RB.AddForce(this.transform.forward * -SPEED * Time.deltaTime);
            AKUSERA_TIME++;
        }
        else if(AKUSERA_TIME == 11)
        {
            W_UP = false;
        }

    }
}
