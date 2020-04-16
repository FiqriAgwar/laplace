using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KartNormalAbility : MonoBehaviour
{
    [Header("Speed Booster")]
    public float boostMultiplier = 5;

    [Header("Missile")]
    public GameObject missile;
    public Transform missileSpawnPoint;

    [Header("Shield")]
    public GameObject shield;
    public float shieldMaxDuration = 5f;
    private float shieldDuration;
    private bool canShoot;
    private bool canShield;
    private bool canBoost;
    private KartController controller;
    private Collider collider;
    
    void Start()
    {
        controller = GetComponent<KartController>();
        collider = GetComponent<Collider>();
        
        shield.SetActive(false);
        shieldDuration = 0;
    }

    void Update()
    {
        if(shield.activeInHierarchy){
            shieldDuration -= Time.deltaTime;
        }

        if(shieldDuration <= 0){
            shield.SetActive(false);
            shieldDuration = 0;
        }

        if((Input.GetAxisRaw("Shoot") > 0) && canShoot){
            Instantiate(missile, missileSpawnPoint.position, missileSpawnPoint.rotation);
            setShoot(false);
        }
        else if((Input.GetAxisRaw("Shield") > 0) && canShield){
            shield.SetActive(true);
            shieldDuration = shieldMaxDuration;
            setShield(false);
        }
        else if((Input.GetAxisRaw("Boost") > 0) && canBoost){
            controller.Boost(boostMultiplier);
            setBoost(false);
        }
    }

    public void setShoot(bool verdict){
        canShoot = verdict;
    }

    public void setShield(bool verdict){
        canShield = verdict;
    }

    public void setBoost(bool verdict){
        canBoost = verdict;
    }
}
