using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class NextPageTutorial : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public bool pressing;

    public GameObject next;
    public GameObject at;
  

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }



    void Start()
    {

    }


    void Update()
    {

        if (pressing)
        {

            next.SetActive(true);
            at.SetActive(false);
            pressing = false;
          
        }

    }

}




