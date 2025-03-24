using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    public StatData data;
    Dictionary<StatType, float> curStats = new Dictionary<StatType, float>();

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

    public float Get(StatType key)
    {
        return curStats.ContainsKey(key) ? curStats[key] : 0;
    }
}
