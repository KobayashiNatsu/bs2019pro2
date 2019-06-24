using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_DetectM : MonoBehaviour {
    private int SUM_PLUS_02, SUM_MINUS_02;
    public Puzzle_Clear Puzzle_Clear;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SUM_PLUS_02 = Puzzle_Clear.SUM_PLUS;
        SUM_MINUS_02 = Puzzle_Clear.SUM_MINUS;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "minus")
        {
            SUM_MINUS_02++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (gameObject.tag == "minus")
        {
            SUM_MINUS_02--;
        }
    }
}
