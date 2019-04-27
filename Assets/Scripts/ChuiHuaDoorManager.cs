using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ChuiHuaDoorManager : MonoBehaviour {

    public VideoPlayer vp;
    public GameObject chuihuamenmodel;
    [HideInInspector]
    public bool canPlay = false;

    void Start()
    {
        //SoundManager.instance.StopBackMusic();
    }

    void Update()
    {
        if(canPlay)
        {
            if(!vp.isPlaying)
            {
                vp.Play();
            }
            chuihuamenmodel.SetActive(false);
        }
        else if(canPlay==false)
        {
            vp.Pause();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
            canPlay = false;
        }
    }

    public void PlayVideo()
    {
        SoundManager.instance.PlayBtnSound();
        canPlay = true;
    }

    public void PauseVideo()
    {
        SoundManager.instance.PlayBtnSound();
        canPlay = false;
    }
}
