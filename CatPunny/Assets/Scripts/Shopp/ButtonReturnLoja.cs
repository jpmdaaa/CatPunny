using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonReturnLoja : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public GameObject page1;
    public GameObject pageat;
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
            page1.SetActive(true);
            pageat.SetActive(false);

   

            pressing = false;

        }


    }
}
