using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    public StatData data;
    public Dictionary<StatType, float> curStats { get; private set; } = new Dictionary<StatType, float>();

    private void Awake()
    {
        InitializeStats();
    }

    void InitializeStats()
    {
        foreach (StatEntry entry in data.stats)
        {
            curStats[entry.statType] = entry.baseValue;
        }
    }
}
