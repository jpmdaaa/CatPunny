using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonGoTutorial : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization
    
    public GameObject hitoria;
    
    
    public bool pressing;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    void Update()
    {
        if (pressing)
        {
          
            hitoria.SetActive(true);
            pressing = false;
            
        }

    }
}
