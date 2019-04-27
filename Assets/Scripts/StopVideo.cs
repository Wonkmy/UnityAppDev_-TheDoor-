using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class StopVideo : MonoBehaviour {

    public VideoPlayer vp;
    public GameObject canvas;
    public ChangeButtonSprite chuangebuttonsprite;
    public Button wangfuBtn;

    void Start()
    {
        canvas.SetActive(false);
        for (int i = 0; i < chuangebuttonsprite.texts.Length; i++)
        {
            chuangebuttonsprite.texts[i].SetActive(false);
        }
        for (int i = 0; i < chuangebuttonsprite.models.Length; i++)
        {
            chuangebuttonsprite.models[i].SetActive(false);
        }
#if UNITY_EDITOR
        HideVideo();
#else
        Invoke("HideVideo", 19);
#endif
    }

    void HideVideo () {
        vp.gameObject.SetActive(false);
        canvas.SetActive(true);
        if(!chuangebuttonsprite.texts[0].activeSelf)
        {
            chuangebuttonsprite.texts[0].SetActive(true);
            wangfuBtn.GetComponent<OnClickBtn>().ChangeSprite(0);
            chuangebuttonsprite.models[0].SetActive(true);
        }
    }
}
