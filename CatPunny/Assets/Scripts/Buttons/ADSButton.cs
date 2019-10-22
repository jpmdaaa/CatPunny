using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Advertisements;

public class ADSButton : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

     Player player;
    public GameObject botao;
    public GameObject text;
    public bool pressing;

    void Start()
    {
        player = FindObjectOfType(typeof(Player)) as Player;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    void Update()
    {
        if(player.life<=2)
        {
            botao.SetActive(true);
            text.SetActive(true);
        }
        else
        {
            botao.SetActive(false);
            text.SetActive(false);
        }
        if (pressing)
        {
            /*

                 if (Advertisement.IsReady("rewardedVideo"))
                 {
                     Advertisement.Show("rewardedVideo");
                 player.life += 1;

             }



             pressing = false;
*/
        }

    }


    }
