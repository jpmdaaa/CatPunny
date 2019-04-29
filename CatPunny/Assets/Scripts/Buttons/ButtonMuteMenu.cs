using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonMuteMenu : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization
    // Use this for initialization

    public bool pressing;

    public GameObject menuaudi0;

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

            menuaudi0.SetActive(false);
        }


    }
}
