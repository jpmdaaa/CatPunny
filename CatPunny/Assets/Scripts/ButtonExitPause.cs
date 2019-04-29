using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonExitPause : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public bool pressing;
    public ButtonPause pause;
    public GameObject BtnPause;
    /*
    public GameObject select;
    public GameObject tutorial;
    */
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    void Update()
    {
        if (pressing)
        {
            // SceneManager.LoadScene(0);

            pause.pressing = false;
            pause.paused = false;
            pressing = false;
            BtnPause.SetActive(true);
            gameObject.SetActive(false);
        }

    }
}



