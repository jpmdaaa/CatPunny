using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerItens : MonoBehaviour
{


    public GameObject[] itens;
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
        if (Time.time > nextRespaw)
        {
            whatToSpawn = Random.Range(1, 11);


            switch (whatToSpawn)
            {
                case 1:
                    Instantiate(itens[0],new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 2:
                    Instantiate(itens[1], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 3:
                    Instantiate(itens[2], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 4:
                    Instantiate(itens[3], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 5:
                    Instantiate(itens[4], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
                case 6:
                    Instantiate(itens[5], new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
                    break;
            

            }
            nextRespaw = Time.time + spawRate;

        }
    }



}
