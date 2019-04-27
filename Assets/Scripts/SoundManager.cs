using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public static SoundManager instance;

	void Awake()
	{
		if(instance==null)
		{
			instance=this;
		}
	}

    private AudioSource audiosource;
    public AudioClip bgMusic;
    public AudioClip btnSound;
	void Start () {
        audiosource = GetComponent<AudioSource>();
	}
	
    /// <summary>
    /// 播放背景音乐
    /// </summary>
    public void PlayBackMusic()
    {
        audiosource.PlayOneShot(bgMusic);
    }

    public void StopBackMusic()
    {
        audiosource.Stop();
    }

    /// <summary>
    /// 播放按键音效
    /// </summary>
    public void PlayBtnSound()
    {
        audiosource.PlayOneShot(btnSound);
    }
}
