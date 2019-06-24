using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt_Move : MonoBehaviour {
    public Renderer REND;
    public float BELT_SPEED = 1.0f;
	// Use this for initialization
	void Start () {
        REND = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
        float offset = Time.time * BELT_SPEED;
        REND.material.SetTextureOffset("_MainTex", new Vector2(offset, 0));
    }
}
