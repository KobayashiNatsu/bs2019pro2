using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Up : MonoBehaviour {
    float TIME_C;
    public Rigidbody D_RB;
    public GameObject Door;
	// Use this for initialization
	void Start () {
        D_RB = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {


        if (TIME_C <= 10)
        {
            TIME_C += 1 * Time.deltaTime;
        }

        if (TIME_C > 3 && TIME_C < 10)
        {
            //D_RB.AddForce(this.transform.up * 1 * Time.deltaTime);
            Vector3 pos = transform.position;
            pos.y += 2.0f * Time.deltaTime;
            transform.position = pos;
        }
	}
}
