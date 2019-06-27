using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Movie_Test : MonoBehaviour {

    //　VideoPlayerコンポーネント
    private VideoPlayer mPlayer;
    //　AudioSourceコンポーネント
    private AudioSource audioSource;
    //　内部に保存したテクスチャを表示するRawImageUI
    public RawImage rImage;
    //　内部スクリプトを出力するUIにTextureをセットしたかどうか
    private bool check = false;

    void Start () {
        mPlayer = GetComponent<VideoPlayer>();
        //　スクリプトでAudioOutputModeをAudioSourceに変更
        mPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;
        //　Directモードはまだサポートされていない為使えない
        //		mPlayer.audioOutputMode = VideoAudioOutputMode.Direct;
        audioSource = GetComponent<AudioSource>();
        //　オーディオトラックを有効にする
        mPlayer.EnableAudioTrack(0, true);
        //　AudioOutPutがAudioSourceの時にスクリプトからAudioSourceを設定する。
        mPlayer.SetTargetAudioSource(0, audioSource);
    }
	
	// Update is called once per frame
	void Update () {
        //　内部に保存しているテクスチャを設定
        if (mPlayer.texture != null && !check)
        {
            Debug.Log("Set");
            rImage.texture = mPlayer.texture;
            check = true;
        }

        mPlayer.Play();
    }
}
