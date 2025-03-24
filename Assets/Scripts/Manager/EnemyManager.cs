using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    GameManager gm;

    Coroutine waveRoutine;

    [SerializeField] List<GameObject> enemyPrefabs;
    Dictionary<string, GameObject> enemyPrefabDic;

    List<GameObject> activeEnemies = new List<GameObject>();

    public Rect spawnArea;
    Color gizmoColor = new Color(1, 0, 0, 0.3f);

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = gizmoColor;
        Vector3 center = new Vector3(spawnArea.x + spawnArea.width / 2, 0, spawnArea.y + spawnArea.height / 2);
        Vector3 size = new Vector3(spawnArea.width, 0.1f, spawnArea.height);
        Gizmos.DrawCube(center, size);
    }
}
