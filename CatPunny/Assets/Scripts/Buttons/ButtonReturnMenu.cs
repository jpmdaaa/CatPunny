using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonReturnMenu : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    public bool pressing;
    /*
    public GameObject Select;
    public GameObject menu;
    public GameObject tutorial;
    */

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
            SceneManager.LoadScene(0);
            /*
            Select.SetActive(false);
            tutorial.SetActive(false);
            menu.SetActive(true);
            pressing = false;
            */

        }

    }
}
