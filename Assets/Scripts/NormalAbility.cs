using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class NormalAbility : NetworkBehaviour
{
    [SerializeField] private string power;
    private Collider collider;

    void Start(){
        collider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Triggered");

            if((power == "Boost") || (power == "Booster")){
                col.gameObject.GetComponent<KartNormalAbility>().setBoost(true);
            }

            if((power == "Shoot") || (power == "Missile")){
                col.gameObject.GetComponent<KartNormalAbility>().setShoot(true);
            }

            if(power == "Shield"){
                col.gameObject.GetComponent<KartNormalAbility>().setShield(true);
            }

            gameObject.SetActive(false);
        }
    }
}
