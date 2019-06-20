using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorConf : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(Cursor.visible == true)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Confined;
            }
            else if (Cursor.visible == false)
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

	}
}
