using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] List<GameObject> enemyPrefabs;
    Dictionary<string, GameObject> enemyPrefabDic;

    List<GameObject> activeEnemies = new List<GameObject>();


}
