using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Espinho : MonoBehaviour {

    private Rigidbody2D rb;
  

    private Transform tr;
   
    public float minAltura;

    private Player player;
    public ButtonPause pause;
    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
       
        player = FindObjectOfType(typeof(Player)) as Player;
      
    }

    private void Update()
    {
       if(!pause.paused)
        {
            if (player.transform.position.x > tr.position.x - 0.9f)
            {
                rb.velocity = new Vector2(rb.velocity.x, -5);
            }


            if (minAltura >= transform.position.y)
            {
                Destroy(gameObject);
            }
        }
        
    }
   

}
