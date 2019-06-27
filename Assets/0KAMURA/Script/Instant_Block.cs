using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instant_Block : MonoBehaviour {

    public GameObject BLOCK_B, BLOCK_R;
    float TIME_COUNT;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        TIME_COUNT += 1 * Time.deltaTime;

        if (TIME_COUNT>5)
        {
            Instantiate(BLOCK_B, this.transform.position, this.transform.rotation);
            TIME_COUNT = 0;
        }

    }
}
