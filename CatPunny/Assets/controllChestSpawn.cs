using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controllChestSpawn : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.tag == "Chest")
        {
            Destroy(gameObject);
        }
    }
}
