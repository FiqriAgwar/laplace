using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitiatePosition : MonoBehaviour
{
    public int rank;
    void Start(){
        SpawnPointGenerator spawner = (SpawnPointGenerator)FindObjectOfType(typeof(SpawnPointGenerator));

        for(int i=0; i<spawner.spawnPoints.Length; i++){
            if(rank == (i+1)){
                if(spawner.spawnPoints[i].player == null){
                    spawner.spawnPoints[i].player = gameObject;
                    gameObject.transform.position = spawner.spawnPoints[i].spawnLocation.position;
                }
            }
        }

        Debug.Log(gameObject.transform.position);
    }
}
