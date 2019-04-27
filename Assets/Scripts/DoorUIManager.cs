using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorUIManager : MonoBehaviour {

    public GameObject MentouText;
    public GameObject MenshenText;
    public GameObject taijiText;

    //public Sprite[] sprites;
    //public Sprite[] spritesBack;

    public GameObject mentouAnim;
    public GameObject menshenAnim;
    public GameObject taijiAnim;



    public Image mentou;
    public Image menshen;
    public Image taiji;

    public int ID;


    void Start()
    {
        //MentouText.SetActive(false);
        MenshenText.SetActive(false);
        taijiText.SetActive(false);

    }

    void Update()
    {
        
    }

    bool obverse = false;
    /// <summary>
    /// 点击右上角门头按钮
    /// </summary>
    public void ClickMentouBtn()
    {
        //mentou.sprite = sprites[0];
        //menshen.sprite = spritesBack[1];
        //taiji.sprite = spritesBack[2];
        SoundManager.instance.PlayBtnSound();
        MentouText.SetActive(true);
        MenshenText.SetActive(false);
        taijiText.SetActive(false);
        mentouAnim.SetActive(true);
        menshenAnim.SetActive(false);
        taijiAnim.SetActive(false);
        if (ID==0)
        {
            //播放王府大门门头动画
            
            AnimManager.instance.wangfumentouAnim.Play("Take 001");
        }
        if(ID==1)
        {
            //播放广亮大门门头动画
            AnimManager.instance.guangliangmentouAnim.Play();
        }
        if(ID==2)
        {
            //播放金柱大门门头动画
            AnimManager.instance.jinzhumentouAnim.Play();
        }
        if (ID == 3)
        {
            //播放蛮子大门门头动画
            AnimManager.instance.manzimentouAnim.Play();
        }
        if (ID == 4)
        {
            //播放如意大门门头动画
            AnimManager.instance.ruyimentouAnim.Play();
        }
    }

    public void ClickMentouBtn1()
    {
        if (ID==0)
        {
            AnimManager.instance.wangfumentouAnim.Play("rewind");
        }
        if (ID == 1)
        {
            AnimManager.instance.guangliangmentouAnim.Play("rewind");
        }
        if (ID == 2)
        {
            AnimManager.instance.jinzhumentouAnim.Play("rewind");
        }
        if (ID == 3)
        {
            AnimManager.instance.manzimentouAnim.Play("rewind");
        }
        if (ID == 4)
        {
            AnimManager.instance.ruyimentouAnim.Play("rewind");
        }
        SoundManager.instance.PlayBtnSound();
    }
    /// <summary>
    /// 点击右上角门身按钮
    /// </summary>
    public void ClickMenshenBtn()
    {
        //mentou.sprite = spritesBack[0];
        //menshen.sprite = sprites[1];
        //taiji.sprite = spritesBack[2];
        SoundManager.instance.PlayBtnSound();
        MentouText.SetActive(false);
        MenshenText.SetActive(true);
        taijiText.SetActive(false);
        mentouAnim.SetActive(false);
        menshenAnim.SetActive(true);
        taijiAnim.SetActive(false);
        if (ID == 0)
        {
            AnimManager.instance.wangfumenshenAnim.Play("Take 001");
        }
        if (ID == 1)
        {
            //播放广亮大门门身动画
            AnimManager.instance.guangliangmenshenAnim.Play();
        }
        if (ID == 2)
        {
            //播放金柱大门门身动画
            AnimManager.instance.jinzhumenshenAnim.Play();
        }
        if (ID == 3)
        {
            //播放蛮子大门门身动画
            AnimManager.instance.manzimenshenAnim.Play();
        }
        if (ID == 4)
        {
            //播放如意大门门身动画
            AnimManager.instance.ruyimenshenAnim.Play();
        }
    }

    public void ClickMenshenBtn1()
    {
        if (ID == 0)
        {
            AnimManager.instance.wangfumenshenAnim.Play("rewind");
        }
        if (ID == 1)
        {
            AnimManager.instance.guangliangmenshenAnim.Play("rewind");
        }
        if (ID == 2)
        {
            AnimManager.instance.jinzhumenshenAnim.Play("rewind");
        }
        if (ID == 3)
        {
            AnimManager.instance.manzimenshenAnim.Play("rewind");
        }
        if (ID == 4)
        {
            AnimManager.instance.ruyimenshenAnim.Play("rewind");
        }
        SoundManager.instance.PlayBtnSound();
    }
    /// <summary>
    /// 点击右上角台基按钮
    /// </summary>
    public void ClicktaijiBtn()
    {
        //mentou.sprite = spritesBack[0];
        //menshen.sprite = spritesBack[1];
        //taiji.sprite = sprites[2];
        SoundManager.instance.PlayBtnSound();
        MentouText.SetActive(false);
        MenshenText.SetActive(false);
        taijiText.SetActive(true);
        mentouAnim.SetActive(false);
        menshenAnim.SetActive(false);
        taijiAnim.SetActive(true);
        if (ID == 0)
        {
            //播放王府大门台基动画
            AnimManager.instance.wangfutaijiAnim.Play();
        }
        if (ID == 1)
        {
            //播放广亮大门台基动画
            AnimManager.instance.guangliangtaijiAnim.Play();
        }
        if (ID == 2)
        {
            //播放金柱大门台基动画
            AnimManager.instance.jinzhutaijiAnim.Play();
        }
        if (ID == 3)
        {
            //播放蛮子大门台基动画
            AnimManager.instance.manzitaijiAnim.Play();
        }
        if (ID == 4)
        {
            //播放如意大门台基动画
            AnimManager.instance.ruyitaijiAnim.Play();
        }
    }

    public void ClicktaijiBtn1()
    {
        
        if (ID==0)
        {
            AnimManager.instance.wangfutaijiAnim.Play("rewind");
        }
        if (ID == 1)
        {
            AnimManager.instance.guangliangtaijiAnim.Play("rewind");
        }
        if (ID == 2)
        {
            AnimManager.instance.jinzhutaijiAnim.Play("rewind");
        }
        if (ID == 3)
        {
            AnimManager.instance.manzitaijiAnim.Play("rewind");
        }
        if (ID == 4)
        {
            AnimManager.instance.ruyitaijiAnim.Play("rewind");
        }
        SoundManager.instance.PlayBtnSound();
    }

}
