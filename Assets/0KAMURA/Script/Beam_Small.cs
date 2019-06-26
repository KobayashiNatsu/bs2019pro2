using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beam_Small : MonoBehaviour {
    public LineRenderer BEAM;
    private Vector3 BEAM_FINISH_ON,BEAM_FINISH_OFF;
    bool BLOCK_ON; 
    // Use this for initialization
    void Start () {
        BEAM_FINISH_ON = new Vector3(0, 0, 0);
        BEAM_FINISH_OFF = new Vector3(0, 15, 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (BLOCK_ON)
        {
            BEAM.SetPosition(1, BEAM_FINISH_ON);
        }
        if (BLOCK_ON == false)
        {
            BEAM.SetPosition(1, BEAM_FINISH_OFF);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "plus"||other.tag=="minus")
        {
            BLOCK_ON = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "plus" || other.tag == "minus")
        {
            BLOCK_ON = false;
        }
    }
}
