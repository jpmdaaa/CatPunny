using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    public bool pressing;

    public GameObject selectopt;
    public GameObject selectperso;



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


    void Update()
    {

        if (pressing)
        {
            selectperso.SetActive(true);
            selectopt.SetActive(false);
        }

    }

}








