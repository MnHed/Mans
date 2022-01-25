using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySpawnPoints : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "SpawnPoint")
        {
            Destroy(other.gameObject);

        }

    }

}
