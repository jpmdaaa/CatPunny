using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonNextPageShop : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject pageat;
    public GameObject nextpage;
    public bool pressing;
    //public ButtonExitSetting btnsetting;
  



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
            pageat.SetActive(false);
            nextpage.SetActive(true);
            pressing = false;
        }


    }
}
