using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlayerStat))]

public class PstatInspectorGui : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();
        if (GUILayout.Button("10������"))
        {
            ((PlayerStat)target).Damage(10);
        }
        if (GUILayout.Button("10����ġ"))
        {
            ((PlayerStat)target).GetExp(10);
        }
        if (GUILayout.Button("10����߰�"))
        {
            ((PlayerStat)target).GetGold(10);
        }
    }
}
