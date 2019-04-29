// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class PlayDog : MonoBehaviour, IPointerDownHandler
{
    //public GameObject fase1;
    public GameObject dog;
    public GameObject select;
    public GameObject canvas;
    public GameObject recorde;
    public bool pressing;
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }




    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (pressing)
        {

            //fase1.SetActive(true);
            dog.SetActive(true);
            select.SetActive(false);
            canvas.SetActive(true);
            recorde.SetActive(true);
            pressing = false;
        }

    }
}






