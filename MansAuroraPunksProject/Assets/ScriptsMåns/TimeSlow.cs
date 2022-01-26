using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSlow : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
   
        if (other.CompareTag("Player"))
        {


            Time.timeScale = Time.timeScale / 2;
            Destroy(gameObject);


        }

    }

}
