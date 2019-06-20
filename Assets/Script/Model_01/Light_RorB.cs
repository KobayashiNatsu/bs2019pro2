using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_RorB : MonoBehaviour {

    Material m;
    static bool main_color = false;

	// Use this for initialization
	void Start () {
        m = gameObject.GetComponent<Renderer>().material;
	}
	
	// Update is called once per frame
	void Update () { 

        if (main_color) {
            m.EnableKeyword("_EMISSION");
            m.SetColor("_EmissionColor",Color.red);
            m.color = Color.red;
            
        }
        else {
            m.EnableKeyword("_EMISSION");
            m.SetColor("_EmissionColor", Color.blue);
            m.color = Color.blue;
            
        }


	}

    public static void Change_color() {
        if (main_color)
        {
            main_color = false;
        }
        else
        {
            main_color = true;
        }
    }
    public static void Change_color(bool color) {
        main_color = color;
    }
    public static bool Get_color() {
        return main_color;
    }
}
