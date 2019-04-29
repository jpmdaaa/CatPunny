using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectToPlay : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization
    public GameObject playetkat;
    public GameObject select;
    //public GameObject fase1;
    public bool pressing;
   
    //public GameObject mute;
    //public Player playerkat;
    //public GameObject recordes;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }



    void Update()
    {
        //playerkat.life = 3;

        if (pressing)
        {
            playetkat.SetActive(true);
            select.SetActive(false);
            //fase1.SetActive(true);
           

            //canvas.SetActive(true);

            //mute.SetActive(true);
            //recordes.SetActive(true);
            pressing = false;
        }


    }



}
