using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotation2 : MonoBehaviour {

    //顔オブジェクト

    public Transform C_Horizon;

    public float ROTATION_SPEED = 20;


    // Use this for initialization
    void Start () {
        C_Horizon = GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void Update () {
        float Y_Rotation = Input.GetAxis("Mouse Y");

        //if (C_Horizon.transform.rotation.y >= -90 && C_Horizon.transform.rotation.y <= 90){
            //C_Horizon.transform.Rotate(-Y_Rotation * ROTATION_SPEED * Time.deltaTime, 0, 0);}

        float nowAngle = (transform.localEulerAngles.x + 90) % 360;

        if (Y_Rotation < 0 && nowAngle < 50) return;
        if (Y_Rotation > 0 && nowAngle > 90) return;

        transform.Rotate(new Vector3(1, 0, 0), -Y_Rotation);
    }
}
