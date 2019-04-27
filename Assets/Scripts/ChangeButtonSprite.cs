using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeButtonSprite : MonoBehaviour {

    public GameObject[] texts;
    public Sprite[] sprites;
    public Sprite[] spritesBack;
    public Sprite wangfuQian;
    public Image[] imgs;
    public GameObject[] models;
    public GameObject wangfuEnter;
    public GameObject guangliangEnter;
    public GameObject jinzhuEnter;
    public GameObject manziEnter;
    public GameObject ruyiEnter;
    public GameObject chuihuaEnter;

    public GameObject wangfuAnimModel;
    public GameObject guangliangAnimModel;
    public GameObject jinzhuAnimModel;
    public GameObject manziAnimModel;
    public GameObject ruyiAnimModel;

    public GameObject wangfubackbtn;
    public GameObject guangliangbackbtn;
    public GameObject jinzhubackbtn;
    public GameObject manzibackbtn;
    public GameObject ruyibackbtn;

    public ChuiHuaDoorManager chuihuadoormanager;

    void Start()
    {
        wangfuEnter.SetActive(false);
        guangliangEnter.SetActive(false);
        jinzhuEnter.SetActive(false);
        manziEnter.SetActive(false);
        ruyiEnter.SetActive(false);
        chuihuaEnter.SetActive(false);
        SoundManager.instance.PlayBackMusic();
    }
    public void WangfuEnter()
    {
        wangfuEnter.SetActive(true);
        wangfuAnimModel.SetActive(true);
        wangfuAnimModel.transform.GetChild(1).gameObject.SetActive(true);
        models[0].SetActive(false);
    }
    public void GuangliangEnter()
    {
        guangliangEnter.SetActive(true);
        guangliangAnimModel.SetActive(true);
        guangliangAnimModel.transform.GetChild(1).gameObject.SetActive(true);
        models[1].SetActive(false);
    }
    public void JinzhuEnter()
    {
        jinzhuEnter.SetActive(true);
        jinzhuAnimModel.SetActive(true);
        jinzhuAnimModel.transform.GetChild(1).gameObject.SetActive(true);
        models[2].SetActive(false);
    }
    public void ManziEnter()
    {
        manziEnter.SetActive(true);
        manziAnimModel.SetActive(true);
        manziAnimModel.transform.GetChild(1).gameObject.SetActive(true);
        models[3].SetActive(false);
    }
    public void RuyiEnter()
    {
        ruyiEnter.SetActive(true);
        ruyiAnimModel.SetActive(true);
        ruyiAnimModel.transform.GetChild(1).gameObject.SetActive(true);
        models[4].SetActive(false);
    }
    public void ChuihuaEnter()
    {
        chuihuaEnter.SetActive(true);
        models[5].SetActive(false);
        if( !chuihuadoormanager.vp.isPlaying)
        {
            chuihuadoormanager.canPlay = true;
        }
        SoundManager.instance.StopBackMusic();
    }

    public void wangfuBack()
    {
        SoundManager.instance.PlayBtnSound();
        wangfuEnter.SetActive(false);
        wangfuAnimModel.SetActive(false);
        models[0].SetActive(true);
        wangfubackbtn.transform.parent.GetComponent<DoorUIManager>().mentouAnim.SetActive(true);
        wangfubackbtn.transform.parent.GetComponent<DoorUIManager>().menshenAnim.SetActive(false);
        wangfubackbtn.transform.parent.GetComponent<DoorUIManager>().taijiAnim.SetActive(false);
    }
    public void guangliangBack()
    {
        SoundManager.instance.PlayBtnSound();
        guangliangEnter.SetActive(false);
        guangliangAnimModel.SetActive(false);
        models[1].SetActive(true);
        guangliangbackbtn.transform.parent.GetComponent<DoorUIManager>().mentouAnim.SetActive(true);
        guangliangbackbtn.transform.parent.GetComponent<DoorUIManager>().menshenAnim.SetActive(false);
        guangliangbackbtn.transform.parent.GetComponent<DoorUIManager>().taijiAnim.SetActive(false);
    }
    public void jinzhuBack()
    {
        SoundManager.instance.PlayBtnSound();
        jinzhuEnter.SetActive(false);
        jinzhuAnimModel.SetActive(false);
        models[2].SetActive(true);
        jinzhubackbtn.transform.parent.GetComponent<DoorUIManager>().mentouAnim.SetActive(true);
        jinzhubackbtn.transform.parent.GetComponent<DoorUIManager>().menshenAnim.SetActive(false);
        jinzhubackbtn.transform.parent.GetComponent<DoorUIManager>().taijiAnim.SetActive(false);
    }
    public void manziBack()
    {
        SoundManager.instance.PlayBtnSound();
        manziEnter.SetActive(false);
        manziAnimModel.SetActive(false);
        models[3].SetActive(true);
        manzibackbtn.transform.parent.GetComponent<DoorUIManager>().mentouAnim.SetActive(true);
        manzibackbtn.transform.parent.GetComponent<DoorUIManager>().menshenAnim.SetActive(false);
        manzibackbtn.transform.parent.GetComponent<DoorUIManager>().taijiAnim.SetActive(false);
    }
    public void ruyiBack()
    {
        SoundManager.instance.PlayBtnSound();
        ruyiEnter.SetActive(false);
        ruyiAnimModel.SetActive(false);
        models[4].SetActive(true);
        ruyibackbtn.transform.parent.GetComponent<DoorUIManager>().mentouAnim.SetActive(true);
        ruyibackbtn.transform.parent.GetComponent<DoorUIManager>().menshenAnim.SetActive(false);
        ruyibackbtn.transform.parent.GetComponent<DoorUIManager>().taijiAnim.SetActive(false);
    }
    public void chuihuaBack()
    {
        SoundManager.instance.PlayBtnSound();
        chuihuaEnter.SetActive(false);
        models[5].SetActive(true);
        chuihuadoormanager.canPlay = false;
        SoundManager.instance.PlayBackMusic();
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}
