using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class EnemyData : ScriptableObject
{

    public GameObject prefab;

    public List<AudioClip> audios = new List<AudioClip>();
}
