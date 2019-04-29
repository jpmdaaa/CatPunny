using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlItensSpawn : MonoBehaviour {


    void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag=="Candies")
        {
            Destroy(gameObject);
        }
    }

    }
