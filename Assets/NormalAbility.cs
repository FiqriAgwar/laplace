using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAbility : MonoBehaviour
{
    [SerializeField] private string power = "Boost";
    private Collider collider;

    void Start(){
        collider = GetComponent<Collider>();
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.tag == "Player"){
            Debug.Log("Triggered");

            if(power == "Boost"){
                col.gameObject.GetComponent<KartNormalAbility>().setBoost(true);
            }

            if(power == "Shoot"){
                col.gameObject.GetComponent<KartNormalAbility>().setShoot(true);
            }

            if(power == "Shield"){
                col.gameObject.GetComponent<KartNormalAbility>().setShield(true);
            }
        }
    }
}
