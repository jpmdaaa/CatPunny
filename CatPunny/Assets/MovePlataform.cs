using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlataform : MonoBehaviour {

    private Transform tr;
    private Rigidbody2D rb;
    public bool maximo;
    public bool minimo;
    public float vel;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }
    void FixedUpdate()
    {
       if(minimo)
        {
            rb.velocity = new Vector2(+vel, rb.velocity.y);
        }
       else if(maximo)
        {
            rb.velocity = new Vector2(-vel, rb.velocity.y);
        }
        
    }
    void OnCollisionEnter2D(Collision2D colisao)
    {
        if(colisao.gameObject.tag=="MaximoPlataformaMovel")
        {
            maximo = true;
            minimo = false;

        }

        if(colisao.gameObject.tag== "MinimoPlataformaMovel")
        {
            maximo = false;
            minimo = true;
        }


    }
 }
