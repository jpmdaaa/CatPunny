﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonPlayGame : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

   
    public bool pressing;

    
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    
   
    

    void Update()
    {
     
        
        if (pressing)
        {
            SceneManager.LoadScene(1);
        }

    }
}
