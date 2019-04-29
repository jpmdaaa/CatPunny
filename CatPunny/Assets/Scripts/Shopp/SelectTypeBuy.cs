using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class SelectTypeBuy : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    public bool pressing;

    public GameObject selectype;
    public GameObject type;



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
            type.SetActive(true);
            selectype.SetActive(false);
    }

}

}




