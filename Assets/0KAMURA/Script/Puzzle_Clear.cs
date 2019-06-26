using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_Clear : MonoBehaviour {

    public int SUM_PLUS = 0, SUM_MINUS = 0;
    public bool ALL_CLEAR;
    //int PLUS_CLEAR = 6, MINUS_CLEAR = 6;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (SUM_PLUS == PLUS_CLEAR && SUM_MINUS == MINUS_CLEAR)
        if (SUM_PLUS == 4 && SUM_MINUS == 4)
        {
            //Debug.Log("Clear!!!!!!!!!!!");
            ALL_CLEAR = true;
        }
	}
}
