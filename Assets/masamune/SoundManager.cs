using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource BGMSource;
    public AudioSource SESource;
    public AudioClip stage1bgm;
    public AudioClip walksound;

    // Start is called before the first frame update
    void Start()
    {
        PlayBGMSound(1);
        SESource.clip = walksound;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.A))
        {
            SESource.Play();
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            SESource.Stop();
        }
        
    }
    public void PlayBGMSound(int stage)
    {
        BGMSource.clip =  stage1bgm;
        BGMSource.Play();
        //イントロ部分の再生開始
        BGMSource.PlayScheduled(AudioSettings.dspTime);

        //イントロ終了後にループ部分の再生を開始
        //BGMSource.PlayScheduled(AudioSettings.dspTime + ((float)BGMSource.clip.samples / (float)BGMSource.clip.frequency));
    }
    public void StartwalkSE()
    {
        SESource.clip = walksound;
        if (Input.GetKeyDown(KeyCode.D)|| Input.GetKeyDown(KeyCode.A))
        {
            SESource.Play();
        }
       
    }
    public void StopwalkSE()
    {
        SESource.clip = walksound;
        SESource.Stop();

    }



}
