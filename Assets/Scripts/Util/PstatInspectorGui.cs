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
        if (GUILayout.Button("10데미지"))
        {
            ((PlayerStat)target).Damage(10);
        }
        if (GUILayout.Button("10경험치"))
        {
            ((PlayerStat)target).GetExp(10);
        }
        if (GUILayout.Button("10골드추가"))
        {
            ((PlayerStat)target).GetGold(10);
        }
    }
}
