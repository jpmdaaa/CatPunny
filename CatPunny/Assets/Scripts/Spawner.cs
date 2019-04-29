using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject[] enemis;
    public float spawRate = 2f;
    public float nextRespaw = 0f;

    int whatToSpawn;
    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextRespaw)
        {
            whatToSpawn = Random.Range(1, 11);


            switch(whatToSpawn)
            {
                case 1:
                    Instantiate(enemis[0], transform.position, Quaternion.identity);
                    break;
                case 2:
                    Instantiate(enemis[1], transform.position, Quaternion.identity);
                    break;
                case 3:
                    Instantiate(enemis[2], transform.position, Quaternion.identity);
                    break;
                case 4:
                    Instantiate(enemis[3], transform.position, Quaternion.identity);
                    break;
                case 5:
                    Instantiate(enemis[4], transform.position, Quaternion.identity);
                    break;
                case 6:
                    Instantiate(enemis[5], transform.position, Quaternion.identity);
                    break;
                case 7:
                    Instantiate(enemis[6], transform.position, Quaternion.identity);
                    break;
                case 8:
                    Instantiate(enemis[7], transform.position, Quaternion.identity);
                    break;
                case 9:
                    Instantiate(enemis[8], transform.position, Quaternion.identity);
                    break;
                case 10:
                    Instantiate(enemis[9], transform.position, Quaternion.identity);
                    break;
                case 11:
                    Instantiate(enemis[10], transform.position, Quaternion.identity);
                    break;

                  
            }
            nextRespaw = Time.time + spawRate;

        }
    }



}
