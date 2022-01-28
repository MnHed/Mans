using System.Collections;
using System.Collections.Generic;
using Unity.FPS.Game;
using Unity.FPS.Gameplay;
using UnityEngine;
using UnityEngine.Events;

public class OneShotScript : MonoBehaviour
{
    
    ProjectileStandard projectile;
    public bool oneShotBuff;
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {

            oneShotBuff = true;
            projectile.Damage = projectile.Damage * 5000;
            Destroy(gameObject);


        }

    }



}
