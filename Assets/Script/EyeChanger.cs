using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EyeChanger : MonoBehaviour
{
    public Renderer Eye, Eye2;
    public Texture[] EyeTexture;
    private int EyeIndex;
    public Button EyeLeft, EyeRight;

    void Start()
    {
        if ((Eye != null || Eye2 != null) && EyeTexture.Length > 0) ;
        {
            Eye.material.mainTexture = EyeTexture[EyeIndex];
            Eye2.material.mainTexture = EyeTexture[EyeIndex];
        }

        EyeLeft.onClick.AddListener(ChangeEyeLeft);
        EyeRight.onClick.AddListener(ChangeEyeRight);

    }

    void ChangeEyeLeft()
    {
        EyeIndex--;
        if (EyeIndex < 0)
        {
            EyeIndex = EyeTexture.Length - 1;
        }
        UpdateEye();
    }

    void ChangeEyeRight()
    {
        EyeIndex++;
        if (EyeIndex >= EyeTexture.Length)
        {
            EyeIndex = 0;
        }
        UpdateEye();
    }

    public void UpdateEye()
    {
        Eye.material.mainTexture = EyeTexture[EyeIndex];
        Eye2.material.mainTexture = EyeTexture[EyeIndex];
    }
}
