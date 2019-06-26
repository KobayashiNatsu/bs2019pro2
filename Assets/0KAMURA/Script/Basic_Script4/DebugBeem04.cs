using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBeem04 : MonoBehaviour {

    public int lifeTime;
    //public GameObject PARENT;
	// Use this for initialization
	void Start () {
        //PARENT = transform.root.gameObject;
        //Debug.Log("Parent:" + PARENT.name);
        transform.parent = GameObject.Find("Head").transform;
    }

    // Update is called once per frame
    void Update () {
        lifeTime--;
        if (lifeTime < 0) Destroy(this.gameObject);
	}
}
