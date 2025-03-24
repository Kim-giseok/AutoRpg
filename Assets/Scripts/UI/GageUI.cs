using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GageUI : BaseUI
{
    public Image gageImg;

    protected override void ChangeUI()
    {
        base.ChangeUI();
        gageImg.fillAmount = amount;
    }
}
