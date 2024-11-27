using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VestChanger : MonoBehaviour
{

    public Renderer Vest, Vest2, Vest3, Leg;
    public Texture[] VestTexture;
    public Texture[] LegTexture;
    private int VestIndex;
    private int LegIndex;
    public Button VestLeft, VestRight, LegLeft, LegRight;

    void Start()
    {
        if ((Vest != null || Vest2 != null || Vest3 != null) && VestTexture.Length > 0)
        {
            Vest.material.mainTexture = VestTexture[VestIndex];
            Vest2.material.mainTexture = VestTexture[VestIndex];
            Vest.material.mainTexture = VestTexture[VestIndex];
            
        }

        else if(Leg != null && LegTexture.Length > 0)
        {
            Leg.material.mainTexture = LegTexture[LegIndex];
        }

        VestLeft.onClick.AddListener(ChangeVestLeft);
        VestRight.onClick.AddListener(ChangeVestRight);
        LegLeft.onClick.AddListener(ChangeLegLeft);
        LegRight.onClick.AddListener(ChangeLegRight);

    }

    void ChangeVestLeft()
    {
        VestIndex--;
        if (VestIndex < 0)
        {
            VestIndex = VestTexture.Length - 1;
        }
        UpdateItem();
    }

    void ChangeVestRight()
    {
        VestIndex++;
        if (VestIndex >= VestTexture.Length)
        {
            VestIndex = 0;
        }
        UpdateItem();
    }

    void ChangeLegLeft()
    {
        LegIndex--;
        if (LegIndex < 0)
        {
            LegIndex = LegTexture.Length - 1;
        }
        UpdateItem();
    }

    void ChangeLegRight()
    {
        LegIndex++;
        if (LegIndex >= LegTexture.Length)
        {
            LegIndex = 0;
        }
        UpdateItem();
    }

    public void UpdateItem()
    {
        Vest.material.mainTexture = VestTexture[VestIndex];
        Vest2.material.mainTexture = VestTexture[VestIndex];
        Vest.material.mainTexture = VestTexture[VestIndex];
        Leg.material.mainTexture = LegTexture[LegIndex];
    }
}
