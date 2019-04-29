using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonDirection : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public Player player;
    public bool pressing;
    public string type;
    //public ButtonExitSetting btnsetting;
    public ButtonPause pause;



    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;

    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pressing && !pause.paused)

        {
           if(type=="right")
            {
                player.estaDeslizando = false;
                player.playerSprite.flipX = player.flipX;
                player.rb.velocity = new Vector2(player.velocidade, player.rb.velocity.y);

                player.estaAndando = true;
            }

            if (type == "left")
            {
                player.estaDeslizando = false;
                player.playerSprite.flipX = !player.flipX;
                player.rb.velocity = new Vector2(-player.velocidade, player.rb.velocity.y);

                player.estaAndando = true;
            }

            if (type == "up")
            {
                player.estaDeslizando = false;
                if (player.estaNoChao || player.estaVoando)
                {
                    player.estaNoChao = false;
                    player.estaPulando = true;
                }
            }
            if (type == "down")
            {
               
                    player.GetComponent<BoxCollider2D>().size = new Vector2(2.33f, 2.0f);
                    player.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1.0f);
                    player.estaDeslizando = true;
            }

           
        }


    }
}
