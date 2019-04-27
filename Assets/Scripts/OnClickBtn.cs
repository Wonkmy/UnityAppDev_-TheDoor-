using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickBtn : MonoBehaviour {

    private int ID;
    public ChangeButtonSprite chuangebuttonsprite;
    private Image image;

    void Awake()
    {
        image = GetComponent<Image>();
    }

    public void ShowText(int id)
    {
        ID = id;
        chuangebuttonsprite.imgs[0].sprite = chuangebuttonsprite.spritesBack[0];
        chuangebuttonsprite.imgs[1].sprite = chuangebuttonsprite.spritesBack[1];
        chuangebuttonsprite.imgs[2].sprite = chuangebuttonsprite.spritesBack[2];
        chuangebuttonsprite.imgs[3].sprite = chuangebuttonsprite.spritesBack[3];
        chuangebuttonsprite.imgs[4].sprite = chuangebuttonsprite.spritesBack[4];
        chuangebuttonsprite.imgs[5].sprite = chuangebuttonsprite.spritesBack[5];
        chuangebuttonsprite.imgs[6].sprite = chuangebuttonsprite.spritesBack[6];
        chuangebuttonsprite.imgs[7].sprite = chuangebuttonsprite.spritesBack[7];
        chuangebuttonsprite.imgs[8].sprite = chuangebuttonsprite.spritesBack[8];



        for (int i = 0; i < chuangebuttonsprite.texts.Length; i++)
        {
            chuangebuttonsprite.texts[i].SetActive(false);
            if(ID == i)
            {
                chuangebuttonsprite.texts[ID].SetActive(true);
            }
        }
    }
    public void ShowModel(int id)
    {
        ID = id;
        //chuangebuttonsprite.imgs[0].sprite = chuangebuttonsprite.wangfuQian;
        for (int i = 0; i < chuangebuttonsprite.models.Length; i++)
        {
            chuangebuttonsprite.models[i].SetActive(false);
            if (ID == i)
            {
                chuangebuttonsprite.models[ID].SetActive(true);
            }
        }
    }

    /// <summary>
    /// 按钮点击后显示按下精灵
    /// </summary>
    public void OnClickBack(int id)
    {
        SoundManager.instance.PlayBtnSound();
        ID = id;
        switch (ID)
        {
            case 0:
                image.sprite = chuangebuttonsprite.sprites[0];
                break;
            case 1:
                image.sprite = chuangebuttonsprite.sprites[1];
                break;
            case 2:
                image.sprite = chuangebuttonsprite.sprites[2];
                break;
            case 3:
                image.sprite = chuangebuttonsprite.sprites[3];
                break;
            case 4:
                image.sprite = chuangebuttonsprite.sprites[4];
                break;
            case 5:
                image.sprite = chuangebuttonsprite.sprites[5];
                break;
            case 6:
                image.sprite = chuangebuttonsprite.sprites[6];
                break;
            case 7:
                image.sprite = chuangebuttonsprite.sprites[7];
                break;
            case 8:
                image.sprite = chuangebuttonsprite.sprites[8];
                break;
            default:
                break;
        }
    }

    public void ChangeSprite(int id)
    {
        image.sprite = chuangebuttonsprite.sprites[id];
    }

    public void ShowNewAddBtnSprite(Sprite _sprite)
    {
        image.sprite = _sprite;
    }
}
