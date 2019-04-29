// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ButtonMute : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public bool pressing;
  
    public GameObject audi2;
  


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
      if(pressing)
        {
           
            audi2.SetActive(false);
           

        }

    }
}