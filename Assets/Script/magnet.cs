﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum MAGNET_PATTERN
{
    PLUS,
    MINUS
}

public class magnet : MonoBehaviour {

    public float rayDistance;
    public GameObject hitObject;

    public MAGNET_PATTERN PlayerMagnet = MAGNET_PATTERN.PLUS;
    public float moveSpeed;
    public float minDistance;
    public float maxDistance;

    Ray targetRay;
    RaycastHit raycast;

    public GameObject localRayStartPos;
    public float rayEndLength;
    public GameObject Debug_BeemOBJ;
    public bool DebugMode;

    bool targetHere = false;
    int targetTime;

    Rigidbody rigid;

	// Use this for initialization
	void Start () {
        rigid = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

        targetRay.origin = localRayStartPos.transform.position;
        targetRay.direction = (transform.forward.normalized * rayEndLength - targetRay.origin).normalized;

        if (DebugMode)
        {
            var beem = Instantiate(Debug_BeemOBJ, localRayStartPos.transform.position, new Quaternion(0, 0, 0, 0), null);
            beem.GetComponent<Rigidbody>().AddForce(targetRay.direction * 500);
        }

        Debug.DrawRay(targetRay.origin, targetRay.direction * rayDistance, Color.yellow, 0.1f, false);

        if (Physics.Raycast(targetRay, out raycast, rayDistance))
        {
            hitObject = raycast.collider.gameObject;
        }
        ////ここまでがレーザーが当たっているオブジェクトのデータの取得

        if (Input.GetKeyDown(KeyCode.M))
        {
            switch (PlayerMagnet)
            {
                case MAGNET_PATTERN.PLUS:
                    PlayerMagnet = MAGNET_PATTERN.MINUS;
                    Light_RorB.Change_color(false);
                    break;
                case MAGNET_PATTERN.MINUS:
                    PlayerMagnet = MAGNET_PATTERN.PLUS;
                    Light_RorB.Change_color(true);
                    break;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return)&& hitObject.tag=="plus")//
        {
            targetHere = true;
        }
        if (Input.GetKeyDown(KeyCode.Return) && hitObject.tag == "minus")//
        {
            targetHere = true;
        }


        if (targetHere == true&& hitObject.tag == "plus")
        {
            if ((transform.position - hitObject.transform.position).sqrMagnitude > minDistance)
            {
                Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position + moveVec);
            }
            else
            {
                targetHere = false;
                hitObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        if (targetHere == true && hitObject.tag == "minus")
        {
            if ((transform.position - hitObject.transform.position).sqrMagnitude < maxDistance)
            {
                Vector3 moveVec = (transform.position - hitObject.transform.position).normalized * moveSpeed;
                hitObject.GetComponent<Rigidbody>().MovePosition(hitObject.transform.position - moveVec);
            }
            else
            {
                targetHere = false;
                hitObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
    }
}
