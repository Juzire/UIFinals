using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HatChanger : MonoBehaviour
{
    public Transform[] Hat;
    private int HatIndex;
    public Button HatLeft, HatRight;

    void Start()
    {
        if (Hat != null && Hat.Length > 0);
        {
            for (int i = 0; i < Hat.Length; i++)
            {
                Hat[i].gameObject.SetActive(i == HatIndex);
            }
            
        }

        HatLeft.onClick.AddListener(ChangeHatLeft);
        HatRight.onClick.AddListener(ChangeHatRight);

    }

    void ChangeHatLeft()
    {
        HatIndex--;
        if (HatIndex < 0)
        {
            HatIndex = Hat.Length - 1;
        }
        UpdateHat();
    }

    void ChangeHatRight()
    {
        HatIndex++;
        if (HatIndex >= Hat.Length)
        {
            HatIndex = 0;
        }
        UpdateHat();
    }

    public void UpdateHat()
    {   
        for (int i = 0; i < Hat.Length; i++)
        {
            Hat[i].gameObject.SetActive(i == HatIndex);
        }

    }
}

