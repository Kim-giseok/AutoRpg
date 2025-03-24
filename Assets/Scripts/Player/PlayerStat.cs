using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    public BaseUI ui;

    public GageStat (float maxStat, float curStat = float.MaxValue, BaseUI ui = null)
    {
        this.ui = ui;
        MaxStat = maxStat;
        CurStat = curStat;
    }
}

public class PlayerStat : MonoBehaviour
{
    [SerializeField] StatHandler statHandler;
    [SerializeField] GageStat hp, mp, exp;
    [SerializeField] float level, gold, dia;
    public BaseUI hpUI, mpUI, expUI, levelUI, goldUI, diaUI;

    void Awake()
    {
        statHandler = GetComponent<StatHandler>();
        hp = new GageStat(statHandler.Get(StatType.Hp), ui: hpUI);
        mp = new GageStat(statHandler.Get(StatType.Mp), ui: mpUI);
        exp  = new GageStat(statHandler.Get(StatType.exp), 0, expUI);
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
}
