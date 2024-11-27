using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinColor : MonoBehaviour
{
    public Renderer SkinObjectRenderer, FaceSkinRenderer, FaceSkinRenderer2, FaceSkinRenderer3;
    public Texture[] SkinTextures;
    public Texture[] FaceSkinTextures;
    private int SkinIndex;
    private int FaceIndex;
    public Button SkinLeft, SkinRight;

    void Start()
    {
        if (SkinObjectRenderer != null  && SkinTextures.Length > 0 || (FaceSkinRenderer != null || FaceSkinRenderer2 != null || FaceSkinRenderer3) && FaceSkinTextures.Length > 0);
        {
            SkinObjectRenderer.material.mainTexture = SkinTextures[SkinIndex];
            FaceSkinRenderer.material.mainTexture = FaceSkinTextures[FaceIndex];
            FaceSkinRenderer2.material.mainTexture = FaceSkinTextures[FaceIndex];
            FaceSkinRenderer3.material.mainTexture = FaceSkinTextures[FaceIndex];
        }

        SkinLeft.onClick.AddListener(ChangeSkinLeft);
        SkinRight.onClick.AddListener(ChangeSkinRight);

    }

    void ChangeSkinLeft()
    {
        SkinIndex--;
        FaceIndex--;
        if (SkinIndex < 0 || FaceIndex < 0)
        {
            SkinIndex = SkinTextures.Length - 1;
            FaceIndex = FaceSkinTextures.Length - 1;
        }
        UpdateSkin();
    }

    void ChangeSkinRight()
    {
        SkinIndex++;
        FaceIndex++;
        if (SkinIndex >= SkinTextures.Length || FaceIndex >= FaceSkinTextures.Length)
        {
            SkinIndex = 0;
            FaceIndex = 0;
        }
        UpdateSkin();
    }

    public void UpdateSkin()
    {
        SkinObjectRenderer.material.mainTexture = SkinTextures[SkinIndex];
        FaceSkinRenderer.material.mainTexture = FaceSkinTextures[FaceIndex];
        FaceSkinRenderer2.material.mainTexture = FaceSkinTextures[FaceIndex];
        FaceSkinRenderer3.material.mainTexture = FaceSkinTextures[FaceIndex];
    }
}
