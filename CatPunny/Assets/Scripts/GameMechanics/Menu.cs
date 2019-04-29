using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ExitShopa : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    // Use this for initialization

    public bool pressing;
    public GameObject select;
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


            Select.SetActive(true);
            pressing = false;
        }

    }
}
