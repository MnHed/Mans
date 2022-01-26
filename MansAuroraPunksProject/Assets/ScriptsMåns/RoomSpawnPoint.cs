using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomSpawnPoint : MonoBehaviour
{
    public int connectToDirection;
    private Variables variables;
    // 1 needs door in X- direction
    // 2 needs door in Z- direction
    // 3 needs door in X+ direction
    // 4 needs door in Z+ direction



    int totalNumberOfRooms;
    int seed;
    int[] completeSeed;
    private bool active = true;
    RoomCategorizer roomCategorizer;




    void Start()
    {
        variables = GameObject.FindGameObjectWithTag("Variable").GetComponent<Variables>();
        Debug.Log(variables.sizeOfMap);
        totalNumberOfRooms = variables.GiveThisVariable();
        completeSeed = new int[totalNumberOfRooms];
        roomCategorizer = GameObject.FindGameObjectWithTag("Rooms").GetComponent<RoomCategorizer>();
        Invoke("SpawnRooms", 0.1f);
    }

    void SpawnRooms()
    {


        if (active == true)
        {
            if (variables.counter < totalNumberOfRooms)
            {

                switch (connectToDirection)
                {

                    case 1:
                        {

                            seed = Random.Range(0, roomCategorizer.XminusRooms.Length);
                            completeSeed[variables.counter] = seed;
                            Instantiate(roomCategorizer.XminusRooms[seed], transform.position, roomCategorizer.XminusRooms[seed].transform.rotation);
                            active = false;
                            variables.counter++;
                            break;

                        }
                    case 2:
                        {

                            seed = Random.Range(0, roomCategorizer.ZminusRooms.Length);
                            completeSeed[variables.counter] = seed;
                            Instantiate(roomCategorizer.ZminusRooms[seed], transform.position, roomCategorizer.ZminusRooms[seed].transform.rotation);
                            active = false;
                            variables.counter++;
                            break;

                        }
                    case 3:
                        {

                            seed = Random.Range(0, roomCategorizer.XplusRooms.Length);
                            completeSeed[variables.counter] = seed;
                            Instantiate(roomCategorizer.XplusRooms[seed], transform.position, roomCategorizer.XplusRooms[seed].transform.rotation);
                            active = false;
                            variables.counter++;
                            break;

                        }
                    case 4:
                        {

                            seed = Random.Range(0, roomCategorizer.ZplusRooms.Length);
                            completeSeed[variables.counter] = seed;
                            Instantiate(roomCategorizer.ZplusRooms[seed], transform.position, roomCategorizer.ZplusRooms[seed].transform.rotation);
                            active = false;
                            variables.counter++;

                            break;

                        }


                    default:
                        active = false;
                        break;
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SpawnPoint"))
        {
            if (other.GetComponent<RoomSpawnPoint>().active == true && active == true)
            {
                Instantiate(roomCategorizer.block, transform.position, transform.rotation);
                Destroy(gameObject);
            }

            
        }
    }

}
