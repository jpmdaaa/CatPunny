using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTrigger : MonoBehaviour {

    private BoxCollider2D playerCollider;

    [SerializeField]
    private BoxCollider2D platformCollider;
    [SerializeField]
    private BoxCollider2D platformTrigger;

    void Start () {
     
        Physics2D.IgnoreCollision(platformCollider, platformTrigger,true);

	}
    void Update()
    {
        playerCollider = GameObject.FindWithTag("Player").GetComponent<BoxCollider2D>();
    }
	
	void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Physics2D.IgnoreCollision(platformCollider, playerCollider,true);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player")
        {
            Physics2D.IgnoreCollision(platformCollider, playerCollider, false);
        }
    }

}
