using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_DetectM : MonoBehaviour {
    public Puzzle_Clear Puzzle_Clear;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "minus")
        {
            Puzzle_Clear.SUM_MINUS++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "minus")
        {
            Puzzle_Clear.SUM_MINUS--;
        }
    }
}
