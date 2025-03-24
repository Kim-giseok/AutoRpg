using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GageStat
{
    [field: SerializeField] public float MaxStat { get; private set; }
    [SerializeField] float curStat;
    public float CurStat
    {
        get => curStat;
        set
        {
            curStat = Mathf.Clamp(value, 0, MaxStat);
            ui?.ChangeAmount(curStat / MaxStat);
        }
    }
    public GageUI ui;
}

public class PlayerStat : MonoBehaviour
{
    [SerializeField] GageStat hp, mp, exp;
    [SerializeField] float level, gold, dia;
    public TxtUI levelUI, goldUI, diaUI;

    private void Start()
    {
        hp.CurStat = hp.MaxStat;
        mp.CurStat = mp.MaxStat;
        exp.CurStat = 0;
    }

    public void Damage(float damage)
    {
        hp.CurStat -= damage;
    }

    public void UseSkill(float cost)
    {
        mp.CurStat -= cost;
    }

    public void GetExp(float exp)
    {
        float gainedExp = this.exp.CurStat + exp;
        if (gainedExp >= this.exp.MaxStat)
        {
            level++;
            levelUI?.ChangeAmount(level);
            this.exp.CurStat = gainedExp - this.exp.MaxStat;
        }
        else
            this.exp.CurStat = gainedExp;
    }

    public void GetGold(float gold)
    {
        this.gold += gold;
        goldUI?.ChangeAmount(this.gold);
    }

    public void GetDia(float dia)
    {
        this.dia += dia;
        diaUI?.ChangeAmount(this.dia);
    }

#if UNITY_EDITOR
    void OnGUI()
    {
        if (GUILayout.Button("10데미지", GUILayout.Width(100), GUILayout.Height(100)))
        {
            Damage(10);
        }
        if (GUILayout.Button("10경험치", GUILayout.Width(100), GUILayout.Height(100)))
        {
            GetExp(10);
        }
        if (GUILayout.Button("10골드추가", GUILayout.Width(100), GUILayout.Height(100)))
        {
            GetGold(10);
        }
    }
#endif
}
