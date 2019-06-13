using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation2 : MonoBehaviour {

    public float ROTAION_SPEEDX = 200;

    public Transform P_VIRTICAL;

    // Use this for initialization
    void Start() {
        P_VIRTICAL = GetComponent<Transform>();
    }	
	// Update is called once per frame
	void Update () {
        float X_Rotation = Input.GetAxis("Mouse X");
        P_VIRTICAL.transform.Rotate(0, X_Rotation * ROTAION_SPEEDX * Time.deltaTime, 0);
	}
}
