// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class BuyIten : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pressing;
    
    public GameObject lojaiten;
    public GameObject activeselect;
    public bool comprado;
    public int itemprice;
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
        //DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (pressing)
        {
            if(Player.money>=itemprice)
            {
              
     
                    activeselect.SetActive(true);
                    Player.money -= itemprice;
                    comprado = true;
                    lojaiten.SetActive(false);
              
               

            }

        }

    }
}






