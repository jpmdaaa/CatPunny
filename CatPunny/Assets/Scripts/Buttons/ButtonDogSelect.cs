using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonDogSelect : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization
    public  GameObject playerdog;
    public GameObject select;
    public GameObject fase1;
    public bool pressing;
    public GameObject buttondog;
    public GameObject canvas;


    public Player playerdog2;
    //public  GameObject dogpurshed;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressing = false;
    }

    void Update()
    {
        //playerdog2.life = 3;

        if (pressing)
        {
            playerdog.SetActive(true);
            select.SetActive(false);
            fase1.SetActive(true);
            buttondog.SetActive(true);
            canvas.SetActive(true);
           

        }
       

    }



}
