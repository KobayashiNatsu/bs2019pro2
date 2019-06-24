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
        if (SUM_PLUS == 1 && SUM_MINUS == 1)
        {
            Debug.Log("Clear!!!!!!!!!!!");
        }
	}
}
