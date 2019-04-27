using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoUIManager : MonoBehaviour {

    public GameObject OneUI;
    public GameObject TwoUI;
    public GameObject ThreeUI;



    void Start()
    {
        if(OneUI.activeSelf)
        {
            OneUI.SetActive(false);
        }
        if (ThreeUI.activeSelf)
        {
            ThreeUI.SetActive(false);
        }
    }

	public void BigDoorBtn(GameObject obj)
    {
        obj.SetActive(false);
        if(!OneUI.activeSelf)
        {
            OneUI.SetActive(true);
        }
    }

    public void BackOneUI(GameObject obj)
    {
        obj.SetActive(true);
        if (OneUI.activeSelf)
        {
            OneUI.SetActive(false);
        }
    }

    public void Ermen(GameObject obj)
    {
        obj.SetActive(true);
        if (TwoUI.activeSelf)
        {
            TwoUI.SetActive(false);
        }
    }

    public void ErmenBackOneUI(GameObject obj)
    {
        obj.SetActive(false);
        if (!TwoUI.activeSelf)
        {
            TwoUI.SetActive(true);
        }
    }
}
