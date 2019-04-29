using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonSkypTutorial : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public bool pressing;
    
    public GameObject select;
    public GameObject tutorial;
    
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    void Update()
    {
        if (pressing)
        {
            
            
            select.SetActive(true);
            tutorial.SetActive(false);
            pressing = false;
           
        }

    }
}
