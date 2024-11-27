using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterCustomization : MonoBehaviour
{
    public Renderer HairObjectRenderer, HairObjectRenderer2, HairObjectRenderer3, HairObjectRenderer4;
    public Texture[] HairTextures;
    private int HairIndex;
    public Button HairLeft, HairRight;

    void Start()
    {
        if ((HairObjectRenderer != null || HairObjectRenderer2 != null || HairObjectRenderer3 != null || HairObjectRenderer4 != null) && HairTextures.Length > 0);
        {
            HairObjectRenderer.material.mainTexture = HairTextures[HairIndex];
            HairObjectRenderer2.material.mainTexture = HairTextures[HairIndex];
            HairObjectRenderer3.material.mainTexture = HairTextures[HairIndex];
            HairObjectRenderer4.material.mainTexture = HairTextures[HairIndex];
        }

        HairLeft.onClick.AddListener(ChangeHairLeft);
        HairRight.onClick.AddListener(ChangeHairRight);

    }

    void ChangeHairLeft()
    {
        HairIndex--;
        if (HairIndex < 0)
        {
            HairIndex = HairTextures.Length - 1;
        }
        UpdateHair();
    }

    void ChangeHairRight()
    {
        HairIndex++;
        if (HairIndex >= HairTextures.Length)
        {
            HairIndex = 0;
        }
        UpdateHair();
    }

    public void UpdateHair()
    {
        HairObjectRenderer.material.mainTexture = HairTextures[HairIndex];
        HairObjectRenderer2.material.mainTexture = HairTextures[HairIndex];
        HairObjectRenderer3.material.mainTexture = HairTextures[HairIndex];
        HairObjectRenderer4.material.mainTexture= HairTextures[HairIndex];
    }
}
