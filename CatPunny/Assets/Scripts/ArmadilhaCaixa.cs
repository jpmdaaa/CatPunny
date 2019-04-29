using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaCaixa : MonoBehaviour {


    private Rigidbody2D rb;
    public bool EstaNoMaximo;
    
    private Transform tr;
    public float maxAltura;
    public float minAltura;
    public float velSubida;
    public float velDescida;
    public bool update1;
    public bool update2;
    public bool update3;
    public bool update4;
    public ButtonPause pause;
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        EstaNoMaximo = false;
       
    }


    void Update()
    {
        if(!pause.paused)
        {
            if (Points.points >= 100 && update1)
            {
                velDescida += 1;
                velSubida += 1;
                update2 = true;
                update1 = false;
            }
            if (Points.points >= 200 && update2)
            {
                velDescida += 2;
                velSubida += 2;
                update3 = true;
                update2 = false;

            }
            if (Points.points >= 300 && update3)
            {
                velDescida += 3;
                velSubida += 3;
                update4 = true;
                update3 = false;
            }
            if (Points.points >= 400 && update4)
            {
                velDescida += 4;
                velSubida += 4;
                update4 = false;

            }


            if (maxAltura > transform.position.y && !EstaNoMaximo)
            {
                rb.velocity = new Vector2(rb.velocity.x, +velSubida);


            }

            if (maxAltura <= transform.position.y)
            {
                EstaNoMaximo = true;
            }

            if (EstaNoMaximo == true)
            {
                rb.velocity = new Vector2(rb.velocity.x, -velDescida);
            }

            if (minAltura > transform.position.y)
            {
                EstaNoMaximo = false;
            }
        }
       
    }
}
