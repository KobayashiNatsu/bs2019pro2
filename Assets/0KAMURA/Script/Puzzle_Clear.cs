using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Clear : MonoBehaviour {

    public int SUM_PLUS, SUM_MINUS;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (SUM_PLUS == 3 && SUM_MINUS == 3)
        {
            Debug.Log("Clear!!!!!!!!!!!");
        }
	}
}
