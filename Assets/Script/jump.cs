using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    bool isJump = true;

    public float JUMP_POWER=10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)&& isJump == true)
        {
            transform.GetComponent<Rigidbody>().AddForce(0, JUMP_POWER, 0, ForceMode.Impulse);
            isJump = false;
        }
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "ground" || collision.gameObject.tag=="plus")
        {
            isJump = true;
        }
    }
}
