using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClotheChanger : MonoBehaviour
{
    public Renderer Clothes, Clothes2, Clothes3;
    public Texture[] ClothesTexture;
    private int ClothesIndex;
    public Button ClothesLeft, ClothesRight;

    void Start()
    {
        if ((Clothes != null || Clothes2 != null || Clothes3 != null) && ClothesTexture.Length > 0) ;
        {
            Clothes.material.mainTexture = ClothesTexture[ClothesIndex];
            Clothes2.material.mainTexture = ClothesTexture[ClothesIndex];
            Clothes3.material.mainTexture = ClothesTexture[ClothesIndex];
        }

        ClothesLeft.onClick.AddListener(ChangeClothesLeft);
        ClothesRight.onClick.AddListener(ChangeClothesRight);

    }

    void ChangeClothesLeft()
    {
        ClothesIndex--;
        if (ClothesIndex < 0)
        {
            ClothesIndex = ClothesTexture.Length - 1;
        }
        UpdateClothes();
    }

    void ChangeClothesRight()
    {
        ClothesIndex++;
        if (ClothesIndex >= ClothesTexture.Length)
        {
            ClothesIndex = 0;
        }
        UpdateClothes();
    }

    public void UpdateClothes()
    {
        Clothes.material.mainTexture = ClothesTexture[ClothesIndex];
        Clothes2.material.mainTexture = ClothesTexture[ClothesIndex];
        Clothes3.material.mainTexture = ClothesTexture[ClothesIndex];
    }
}
