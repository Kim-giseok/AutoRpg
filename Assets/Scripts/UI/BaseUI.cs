using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseUI : MonoBehaviour
{
    public float amount;

    public virtual void ChangeAmount(float amount)
    {
        this.amount = amount;
        ChangeUI();
    }

    protected virtual void ChangeUI()
    {

    }
}
