// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SelectRoupa : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pressing;

    public GameObject selectitem;
    public GameObject activegame;
    public GameObject activegamedog;
    public GameObject activetestekat;
    public GameObject activetestedog;
   
   
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
          
                selectitem.SetActive(false);
                activegame.SetActive(true);
                activegamedog.SetActive(true);
            activetestedog.SetActive(true);
            activetestekat.SetActive(true);
            pressing = false;
     

        }

    }
}






