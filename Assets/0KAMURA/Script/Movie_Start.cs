using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Movie_Start : MonoBehaviour {
    public Canvas DOUGA;
    public Puzzle_Clear P_CLEAR;
    bool DOUGA_START;
    float DOUGA_TIME;

    //　VideoPlayerコンポーネント
    private VideoPlayer mPlayer;
    //　AudioSourceコンポーネント
    private AudioSource audioSource;
    //　内部に保存したテクスチャを表示するRawImageUI
    public RawImage rImage;
    //　内部スクリプトを出力するUIにTextureをセットしたかどうか
    private bool check = false;


    // Use this for initialization
    void Start () {
        DOUGA.enabled = false;

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

        mPlayer.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (mPlayer.texture != null && !check)
        {
            //Debug.Log("Set");
            rImage.texture = mPlayer.texture;
            check = true;
        }

        if (P_CLEAR.ALL_CLEAR)
        {
            DOUGA_START = true;
            DOUGA_TIME += 1 * Time.deltaTime;
        }

        if (DOUGA_START && DOUGA_TIME <= 8)
        {
            DOUGA.enabled = true;
            mPlayer.Play();

        }
        if (DOUGA_TIME >= 9&&DOUGA_TIME<=10)
        {
            DOUGA.enabled = false;
            DOUGA_START = false;
        }

    }
}
