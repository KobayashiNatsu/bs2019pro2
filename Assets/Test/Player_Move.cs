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


    // Use this for initialization
    void Start () {
        P_RB = GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

        //P_MOVE = PLAYER_H.GetComponent<Player_Rotation>();

        //Vector3 PV= PLAYER_H.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            
            P_RB.AddForce(this.transform.forward * SPEED * Time.deltaTime);
        }
      
            if (Input.GetKeyUp(KeyCode.W))
        {
            P_RB.velocity = Vector3.zero;
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

    }
}
