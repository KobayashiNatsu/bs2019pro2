using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotation : MonoBehaviour {

    // カメラオブジェクトを格納する変数
    public Camera mainCamera;
    // カメラの回転速度を格納する変数
    public Vector2 rotationSpeed;
    // マウス座標を格納する変数
    private Vector2 lastMousePosition;
    // カメラの角度を格納する変数（初期値に0,0を代入）
    private Vector2 newAngle = new Vector2(0, 0);

    //顔オブジェクト
    public GameObject Head;

    // Use this for initialization
    void Start () {


		
	}
	
	// Update is called once per frame
	void Update () {

        // 左クリックした時
        if (Input.GetMouseButtonDown(0))
        {
            // カメラの角度を変数"newAngle"に格納
            newAngle = mainCamera.transform.localEulerAngles;
            // マウス座標を変数"lastMousePosition"に格納
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            // Y軸の回転：マウスドラッグと逆方向に視点回転
            //newAngle.y -= (lastMousePosition.x - Input.mousePosition.x) * rotationSpeed.y;
            // X軸の回転：マウスドラッグと逆方向に視点回転
            newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotationSpeed.x;
            
            // "newAngle"の角度をカメラ角度に格納
            //mainCamera.transform.localEulerAngles = newAngle;

            if(newAngle.x>=-90&&newAngle.x<=90)
            Head.transform.localEulerAngles = newAngle;

            // マウス座標を変数"lastMousePosition"に格納
            lastMousePosition = Input.mousePosition;
        }

    }
}
