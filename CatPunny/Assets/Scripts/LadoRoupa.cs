using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadoRoupa : MonoBehaviour {

    private SpriteRenderer roupa;
    public bool flipX;
    public static bool mudalado;

    // Use this for initialization
    void Start () {
        roupa = GetComponent<SpriteRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        if(mudalado)
        {
            roupa.flipX = !flipX;
        }

        if(!mudalado)
        {
            roupa.flipX = flipX;
        }
    }


  
}
