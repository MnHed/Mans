using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawnPoints : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("SpawnPoint") || other.CompareTag("Rooms"))
        {
            Destroy(other.gameObject);

        }

        

    }

}
