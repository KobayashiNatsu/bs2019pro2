using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle_DetectP : MonoBehaviour {
    public Puzzle_Clear Puzzle_Clear;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("当たった");
        if (other.tag == "plus")
        {
            Puzzle_Clear.SUM_PLUS++;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "plus")
        {
            Puzzle_Clear.SUM_PLUS--;
        }
    }
}
