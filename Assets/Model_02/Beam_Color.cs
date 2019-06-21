using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam_Color : MonoBehaviour {


    ParticleSystem p;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        p = GetComponent<ParticleSystem>();
        var main = p.main;
        if (Light_RorB.Get_color()){
            main.startColor = Color.red;
        }
        else {
            main.startColor = Color.blue;
        }

    }
}
