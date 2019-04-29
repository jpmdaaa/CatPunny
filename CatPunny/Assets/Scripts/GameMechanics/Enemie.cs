using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemie : MonoBehaviour {

    public Rigidbody2D rb;
    public SpriteRenderer playerSprite;
    public Transform tr;
    private Animator an;
    public Transform verificaChao;
    public Transform verificaParede;

    private bool estaNaParede;
    public bool estaNoChao;
    private bool viradoParaDireita;
    public float raioValidaChao;
    public float raioValidaParede;
    public float velocidade;
    public LayerMask Solid;
    private ButtonPause pause;


    // Use this for initialization
    void Awake () {
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        an = GetComponent<Animator>();
        viradoParaDireita = true;
        pause = FindObjectOfType(typeof(ButtonPause)) as ButtonPause;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
    
        {
            EnemyMovements();
        }
    
	}

    void EnemyMovements()
    {
        estaNoChao = Physics2D.OverlapCircle(verificaChao.position, raioValidaChao, Solid);
        estaNaParede = Physics2D.OverlapCircle(verificaParede.position, raioValidaParede, Solid);

        if((!estaNoChao || estaNaParede) && viradoParaDireita)
        {
            Flip();
        }
        else if  ((!estaNoChao || estaNaParede) && !viradoParaDireita)  
        {
            Flip();
        }

        if (estaNoChao)
        {
            rb.velocity = new Vector2(velocidade, rb.velocity.y);
        }

    }

    void Flip()
    {
        viradoParaDireita = !viradoParaDireita;
        tr.localScale = new Vector2(-tr.localScale.x, tr.localScale.y);

        velocidade *= -1;

    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(verificaChao.position, raioValidaChao);
        Gizmos.DrawWireSphere(verificaParede.position, raioValidaParede);
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {

        if (colisao.gameObject.tag == ("Enemy"))
        {
            Destroy(colisao.gameObject);
            //Flip();
            
        }

    }



    }
