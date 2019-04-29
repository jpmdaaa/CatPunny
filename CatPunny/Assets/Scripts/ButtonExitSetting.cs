using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonExitSetting : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{

    public GameObject buttonmute;
    public GameObject buttononmute;
    public GameObject buttonexit;
    public GameObject buttonsetings;
    public GameObject buttonexitgame;
    public GameObject buttonController;
    public bool pressing;
    //public ButtonSetings btnsetings;




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

    // Update is called once per frame
    void Update()
    {
        if (pressing)

        {
            buttonsetings.SetActive(true);
            buttonexit.SetActive(false);
            buttononmute.SetActive(false);
            buttonmute.SetActive(false);
            buttonexitgame.SetActive(false);
            buttonController.SetActive(false);
            pressing = false;
        }


    }
}

