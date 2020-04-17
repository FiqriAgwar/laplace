using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointGenerator : MonoBehaviour
{
    public SpawnPoint[] spawnPoints;

    void Awake(){
        int i = 1;
        foreach(SpawnPoint spawnPoint in spawnPoints){
            spawnPoint.id = i;
            i++;
            spawnPoint.player = null;
        }
    }
}
