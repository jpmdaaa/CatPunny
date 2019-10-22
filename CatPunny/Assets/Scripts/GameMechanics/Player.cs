using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour {
    [Header("MOVIMENT AND GERAL")]
    public Rigidbody2D rb;
    public SpriteRenderer playerSprite;
    public Transform faseStart;
    public Transform tr;
    private Animator an;
    public float velocidade;
    public float velocidadei=2;
    public int life=3;
    public Transform verificaChao;
    public Transform verificaParede;
    //public ControlSelect control;
    public Slider slider;
    public Slider sliderpower;
    public bool estaAndando;
    public bool estaNoChao;
    public bool estaNaParede;
    private bool estaVivo;
    public bool flipX;
    public static int money;
    private float timerdoor1;
    //public Text aceller;
    public float Acell;
    //public GameObject gameover;
    public GameObject Canvasplayer;
    public changeComands mudarcomandos;
    //public GameObject champselect;
    private SoundEffect sound;
    private BoxCollider2D colisor;
    private float axis;
    public float forcaPulo;
    public float raioValidaChao;
    public float raioValidaParede;
    public bool estaPulando;
    public bool Segundopulo;
    public float timer;
    public bool estaparado;
    public AnimationClip anim;
    public bool estaDeslizando;
    public LayerMask Solid;
    private string direction;
    public ButtonPause pause;
    public GameObject Camera;


    private SpriteRenderer spriteRender;

    [Header("Powers")]
    //powers
    public float timerpower;
    private int poderaleatorio;
    public bool poder;
    public GameObject raio;
    public GameObject power2;
    public bool imortality;
    public GameObject angel;
    public bool estaVoando;
    public GameObject Fire;
    public bool fire;
    public bool update1;
    public bool update2;
    public bool update3;
    public bool update4;
    private bool poweractive;
    [Header("UI")]
    public Player KATPLAYER;
    public GameObject coin;
    public GameObject[] Chekpoints;
    public GameObject Gameover;
    public GameObject plataform;
    public GameObject KatPlayer;
    public GameObject lifeUI;
    public GameObject settingsUI;
    public GameObject pointsUI;
    public GameObject PowerBar;

    // Use this for initialization
    void Start () {
       
        playerSprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
        an = GetComponent<Animator>();
        life = 3;
        estaVivo = true;
        estaparado = true;
        spriteRender = GetComponent<SpriteRenderer>();
        sound = FindObjectOfType(typeof(SoundEffect)) as SoundEffect;
        colisor = GetComponent<BoxCollider2D>();
        timer = 0;
        lifeUI.SetActive(true);
        settingsUI.SetActive(true);
        pointsUI.SetActive(true);
        PowerBar.SetActive(false);
        //transform.position = new Vector2(Chekpoints[0].transform.position.x, Chekpoints[0].transform.position.y);


    }
	
	// Update is called once per frame
	void Update () {

        TesteParedeEChao();
        TestCair();
        AtualizacaoAcelerometro();
        AttUL();
        Animacoes();

        if (estaVivo && !pause.paused)
        {
          
            Moviment();
            Powers();
            ProgressaoDificuldade();
            Deslizamento();
           
        }

       


    }

    void FixedUpdate()
    {


        if(estaPulando)
        {
            rb.AddForce(tr.up * forcaPulo);
            estaPulando = false;
        }


        if (life <= 0)
        {

           
            timer++;
               
            an.SetTrigger("Died");
            Points.points = 0;
            estaVivo = false;
        
            if(timer>100)
            {
                Camera.SetActive(false);
                spriteRender.enabled = false;
                plataform.SetActive(false);
                desactivePowers();
                Gameover.SetActive(true);
              

            }
            if (timer > 300)
            {
               
                lifeUI.SetActive(false);
               
                    SceneManager.LoadScene(1);


            }
            


        }
   
    }

     void Moviment()
    {
        if (rb.velocity.x <= 0)
        {
            estaAndando = false;
        }

        //   TESTE PC

        if (Input.GetKeyDown(KeyCode.UpArrow) && estaNoChao)
        {

            estaNoChao = false;
            estaPulando = true;
            Segundopulo = true;

        }


        if (Input.GetKeyDown(KeyCode.UpArrow) && estaNaParede)
        {


            estaNoChao = false;
            estaPulando = true;
            Segundopulo = true;

        }



        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerSprite.flipX = flipX;
            rb.velocity = new Vector2(velocidade * 2, rb.velocity.y);
            //an.SetTrigger("Walk");
            if (estaNoChao)
            {
                estaAndando = true;
            }

        }




        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerSprite.flipX = !flipX;
            rb.velocity = new Vector2(-velocidade * 2, rb.velocity.y);
            //an.SetTrigger("Walk");
            if (estaNoChao)
            {
                estaAndando = true;
            }

        }


        //CONTROLE ACELEROMETRO
        if (mudarcomandos.control1)
        {


            //teste acelerometro
            if (Acell > 0.08)
            {
                playerSprite.flipX = flipX;

                rb.velocity = new Vector2(velocidade, rb.velocity.y);
                estaAndando = true;

            }



            if (Acell < 0.08)
            {
                playerSprite.flipX = !flipX;
                rb.velocity = new Vector2(-velocidade, rb.velocity.y);

                estaAndando = true;

            }


        }


        //CONTROLE TOUCH
        foreach (Touch touch in Input.touches)
        {

            {
                if (touch.position.x > 360 && touch.position.y < 500)
                {

                    playerSprite.flipX = flipX;

                    rb.velocity = new Vector2(velocidade, rb.velocity.y);
                    estaAndando = true;


                }

                if (touch.position.x < 360 && touch.position.y < 500)
                {

                    playerSprite.flipX = !flipX;
                    rb.velocity = new Vector2(-velocidade, rb.velocity.y);

                    estaAndando = true;



                }


            }

            if (touch.position.y >= 500 && estaNoChao)
            {

                estaNoChao = false;
                estaPulando = true;


            }



           

        }
    }
     void TestCair()
    {

        //teste se cair
        if (tr.position.y <= -4)
        {

            if (transform.position.x > Chekpoints[0].transform.position.x && transform.position.x < Chekpoints[1].transform.position.x)
            {
                transform.position = new Vector3(Chekpoints[0].transform.position.x, Chekpoints[0].transform.position.y, -2);
            }


            if (transform.position.x > Chekpoints[1].transform.position.x && transform.position.x < Chekpoints[2].transform.position.x)
            {
                transform.position = new Vector3(Chekpoints[1].transform.position.x, Chekpoints[1].transform.position.y, -2);
            }



            if (transform.position.x > Chekpoints[2].transform.position.x && transform.position.x < Chekpoints[3].transform.position.x)
            {
                transform.position = new Vector3(Chekpoints[2].transform.position.x, Chekpoints[2].transform.position.y, -2);
            }

            if (transform.position.x > Chekpoints[3].transform.position.x)
            {
                transform.position = new Vector3(Chekpoints[3].transform.position.x, Chekpoints[3].transform.position.y, -2);
            }

            life -= 1;


        }


    }
     void Powers()
     {
      
        if (poderaleatorio <= 30 && poderaleatorio > 0)
        {
            timerpower += 1.0f;
            power2.SetActive(true);

            imortality = true;
            poweractive = true;
        }

        if (poderaleatorio > 30 && poderaleatorio <= 100)
        {
            raio.SetActive(true);
            velocidade = 3;
            timerpower += 0.5f;
            poweractive = true;
        }
        /*
        if (poderaleatorio > 80)
        {
            
            angel.SetActive(true);
            timerpower += 1.5f;
            estaVoando = true;
            rb.gravityScale = 0.5f;

            Fire.SetActive(true);
              
         }
      */



        if (timerpower > 500)
        {

            desactivePowers();
        }

    }
     void desactivePowers()
    {
        power2.SetActive(false);
        velocidade = velocidadei;
        raio.SetActive(false);
        angel.SetActive(false);
        Fire.SetActive(false);
        fire = false;
        imortality = false;
        poweractive = false;
        estaVoando = false;
        timerpower = 0;
        poderaleatorio = 0;
        rb.gravityScale = 1;
        PowerBar.SetActive(false);
    }
     void ProgressaoDificuldade()
      {
        /*
        //Progressao dificuldade
        if (Points.points >= 100 && update1)
        {
            velocidade += 1;
            update2 = true;
            update1 = false;
        }

        if (Points.points >= 200 && update2)
        {
            velocidade += 1;
            update3 = true;
            update2 = false;
        }
        if (Points.points >= 300 && update3)
        {
            velocidade += 1;
            update4 = true;
            update3 = false;

        }
        if (Points.points >= 400 && update4)
        {
            velocidade += 1;
            update4 = false;

        }
        */

    }
     void Animacoes()
    {
        an.SetBool("EstaAndando", estaAndando);
        an.SetBool("EstaPulando", !estaNoChao);
        an.SetBool("EstaDeslizando", estaDeslizando);
    }
     void TesteParedeEChao()
     {
        //verificar se esta no chao
        estaNoChao = Physics2D.OverlapCircle(verificaChao.position, raioValidaChao, Solid);
        //verificar se esta na parede
        estaNaParede = Physics2D.OverlapCircle(verificaParede.position, raioValidaParede, Solid);
    }
     void AtualizacaoAcelerometro()
    { 
        //atualizar acelerometro
        Acell = Input.acceleration.x;

    }
     void AttUL()
     {
        //atualizar barra vida e poder 
        slider.value = life;
        sliderpower.value = timerpower;

     }
     void Deslizamento()
    {
        //colizor diminuindo 
        if (estaDeslizando == false)
        {
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(2.33f, 4.09f);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);

        }

    }
    void ReturnChekpoint()
    {

        if (transform.position.x > Chekpoints[0].transform.position.x && transform.position.x < Chekpoints[1].transform.position.x)
        {
            transform.position = new Vector3(Chekpoints[0].transform.position.x, Chekpoints[0].transform.position.y, -2);
        }


        if (transform.position.x > Chekpoints[1].transform.position.x && transform.position.x < Chekpoints[2].transform.position.x)
        {
            transform.position = new Vector3(Chekpoints[1].transform.position.x, Chekpoints[1].transform.position.y, -2);
        }



        if (transform.position.x > Chekpoints[2].transform.position.x && transform.position.x < Chekpoints[3].transform.position.x)
        {
            transform.position = new Vector3(Chekpoints[2].transform.position.x, Chekpoints[2].transform.position.y, -2);
        }

        if (transform.position.x > Chekpoints[3].transform.position.x)
        {
            transform.position = new Vector3(Chekpoints[3].transform.position.x, Chekpoints[3].transform.position.y, -2);
        }
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(verificaChao.position, raioValidaChao);
        Gizmos.DrawWireSphere(verificaParede.position, raioValidaParede);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Enemy")
        {
            collision.gameObject.transform.position = new Vector2(colisor.gameObject.transform.position.x + 1, colisor.gameObject.transform.position.y);

            Instantiate(coin, collision.gameObject.transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
        }
    }
  

    void OnCollisionEnter2D(Collision2D colisao)
    {
        //colisoes  
        if(colisao.gameObject.tag==("Armadilha") && !imortality)
        {
            if(!fire)
            {
                life -= 1;
                ReturnChekpoint();

                sound.MakecolidSound();
            }
            else if(fire)
            {
                Destroy(colisao.gameObject);
            }
          
            //transform.position = new Vector2(0.91f, 0);
        }

        if (colisao.gameObject.tag == ("Candies"))
        {
            sound.MakeFoodSound();
            Destroy(colisao.gameObject);    
            Points.points += 1;
           
        }

        

        if (colisao.gameObject.tag == ("heartPlus"))
        {
            Destroy(colisao.gameObject);
            if(life < 3)
            {
                life += 1;
            }

          

        }

        if (colisao.gameObject.tag == ("Enemy"))
        {
             sound.MakecolidSound();
             Destroy(colisao.gameObject);
              if(!fire && !imortality )
              {
                life -= 1;
                ReturnChekpoint();
            }       
            
 
        }
        
       
        if (colisao.gameObject.tag == ("Espinho")&&!imortality)
        {
            if(!fire)
            {
                sound.MakecolidSound();
                life -= 1;
                ReturnChekpoint();

            }

            Destroy(colisao.gameObject);
           
        }

        if (colisao.gameObject.tag == ("Coin"))
        {
            sound.MakepointSound();
            Destroy(colisao.gameObject);
            //money++;
            Points.points += 20;
        
           
        }


        if (colisao.gameObject.tag == ("Saw"))
        {
         if(!fire)
            {
                life = 0;
            }
         else if(fire)
            {
                Destroy(colisao.gameObject);
            }
          
        }

        if (colisao.gameObject.tag == ("Door"))
        {
            gameObject.transform.position = Chekpoints[0].transform.position;
            Points.points += 10;
            velocidade = velocidade * 1.25f;
            
        
        }

        if (colisao.gameObject.tag == ("Chest") )
        {
            Destroy(colisao.gameObject);
            sound.MakepointSound();
            timerpower = 0;
            if (!poweractive)
            {
                poderaleatorio = Random.Range(1, 100);
               
                PowerBar.SetActive(true);

                //bau.SetBool("abrir", true);
            }


        }

    }
}



