﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Belt_Effect : MonoBehaviour {
    bool ON_BELT;
    public Vector3 DriveDirection = Vector3.forward;
    public float CurrentSpeed { get { return _currentSpeed; } }
    public float TargetDriveSpeed = 3.0f;
    [SerializeField] private float _forcePower = 50f;
    private float _currentSpeed = 0;
    private List<Rigidbody> _rigidbodies = new List<Rigidbody>();

    // Use this for initialization
    void Start () {
        DriveDirection = DriveDirection.normalized;
    }

    // Update is called once per frame
    void Update () {
        _currentSpeed = ON_BELT ? TargetDriveSpeed : 0;
        //消滅したオブジェクトは除去する
        _rigidbodies.RemoveAll(r => r == null);

        foreach (var r in _rigidbodies)
        {
            //物体の移動速度のベルトコンベア方向の成分だけを取り出す
            var objectSpeed = Vector3.Dot(r.velocity, DriveDirection);

            //目標値以下なら加速する
            if (objectSpeed < Mathf.Abs(TargetDriveSpeed))
            {
                r.AddForce(DriveDirection * _forcePower, ForceMode.Acceleration);
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
        _rigidbodies.Add(rigidBody);
    }

    void OnCollisionExit(Collision collision)
    {
        var rigidBody = collision.gameObject.GetComponent<Rigidbody>();
        _rigidbodies.Remove(rigidBody);
    }

}
