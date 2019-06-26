using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaaaaaaaaaaas : MonoBehaviour {
    private Renderer _renderer;
    public float TIME_C,TIME_MAX;
    // Use this for initialization
    void Start () {
        _renderer = GetComponent<Renderer>();
        StartCoroutine(BlinkerCoroutine());

    }

    // Update is called once per frame
    void Update () {
        TIME_C += 1 * Time.deltaTime;
	}

    IEnumerator BlinkerCoroutine()
    {
        //こちらは悪い例(変化しない)
        //変更前のマテリアルのコピーを保存
        var originalMaterial = new Material(_renderer.material);
        for (; ; )
        {
            //if (TIME_C < TIME_MAX)
            //{
                _renderer.material.SetColor("_EmissionColor", new Color(0.2f, 0.9f, 0.2f)); //赤色に光らせたい
                yield return new WaitForSeconds(0.7f); //1秒待って
                _renderer.material = originalMaterial; //元に戻す
                yield return new WaitForSeconds(0.7f); //また1秒待ってくりかえし
            //}
            
            //if(TIME_C==TIME_MAX)
            //{
            //    _renderer.material.SetColor("_EmissionColor", new Color(0, 0.3f, 0.0f)); //赤色に光らせたい
            //}
        }
    }

}
