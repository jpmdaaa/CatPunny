using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonShop : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    public bool pressing;
    public GameObject loja;
    public bool comproudog;
    public GameObject Select;

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
        if (pressing)
        {

            loja.SetActive(true);
            Select.SetActive(false);
            pressing = false;
          
        }
        


    }
}
