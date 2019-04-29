using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonOnmute : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization
    
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
       
    }


    void Update()
    {

        if (pressing)
        {
            
            audi2.SetActive(true);
         



        }
       
    }

}
