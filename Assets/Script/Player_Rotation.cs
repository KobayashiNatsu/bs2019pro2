using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Rotation : MonoBehaviour {

    // カメラオブジェクトを格納する変数
    public Camera mainCamera2;
    // カメラの回転速度を格納する変数
    public Vector2 rotationSpeed2;
    // マウス座標を格納する変数
    private Vector2 lastMousePosition2;
    // カメラの角度を格納する変数（初期値に0,0を代入）
    public Vector2 newAngle2 = new Vector2(0, 0);

    //体オブジェクト
    public GameObject Body;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            // カメラの角度を変数"newAngle"に格納
            newAngle2 = this.transform.localEulerAngles;
            // マウス座標を変数"lastMousePosition"に格納
            lastMousePosition2 = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            // Y軸の回転：マウスドラッグと逆方向に視点回転
            newAngle2.y -= (lastMousePosition2.x - Input.mousePosition.x) * rotationSpeed2.y;
            // X軸の回転：マウスドラッグと逆方向に視点回転
            //newAngle.x -= (Input.mousePosition.y - lastMousePosition.y) * rotationSpeed.x;

            // "newAngle"の角度をカメラ角度に格納
            //mainCamera.transform.localEulerAngles = newAngle;

            this.transform.localEulerAngles = newAngle2;

            // マウス座標を変数"lastMousePosition"に格納
            lastMousePosition2 = Input.mousePosition;

        }
    }
}
