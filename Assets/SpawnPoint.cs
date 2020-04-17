using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SpawnPoint
{
    [HideInInspector]public int id;
    public Transform spawnLocation;
    [HideInInspector]public GameObject player;
}
