using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class changeComands : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization
    public bool pressing;
    public bool control1;
    public bool control2=true;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;


    }
    void Update()
    {
        if (pressing&& control1)
        {
       
                control1 = false;
                control2 = true;
              
            pressing = false;
            

           

        }
        if (pressing && control2)
        {
          
                control1 = true;
                control2 = false;

            
            pressing = false;

        }


    }
}




