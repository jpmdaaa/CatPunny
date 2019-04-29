using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class exitselectroupa : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public GameObject selectroupa;
    //public GameObject fase1;
    public bool pressing;

    public GameObject select;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }



    void Update()
    {
        //playerkat.life = 3;

        if (pressing)
        {

            selectroupa.SetActive(false);
            //fase1.SetActive(true);


            select.SetActive(true);
            pressing = false;


        }


    }



}









