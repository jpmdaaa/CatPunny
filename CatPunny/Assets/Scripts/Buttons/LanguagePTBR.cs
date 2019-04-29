using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LanguagePTBR : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public bool pressing;

    public GameObject ptbr;
    public GameObject eng;
    public GameObject canvas;

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

            ptbr.SetActive(true);
            eng.SetActive(false);
            canvas.SetActive(false);

        }

    }

}






