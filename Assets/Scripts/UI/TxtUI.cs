using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TxtUI : BaseUI
{
    public TextMeshProUGUI txt;

    protected override void ChangeUI()
    {
        base.ChangeUI();
        txt.text = amount.ToString();
    }
}
