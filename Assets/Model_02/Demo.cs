using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {

            Light_RorB.Change_color();//この関数を使って赤と青の間で変わる。

        }
        if (Input.GetKeyDown(KeyCode.R))
        {

            Light_RorB.Change_color(true);//この関数を使って赤に変わる。

        }
        if (Input.GetKeyDown(KeyCode.B))
        {

            Light_RorB.Change_color(false);//この関数を使って青に変わる。

        }
    }
}
