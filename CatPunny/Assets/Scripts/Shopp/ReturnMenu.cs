// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class ReturnMenu: MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{

    public bool pressing;
    public GameObject selectclothes;
    public GameObject loja2;
    public ButtonShop btnshop;
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
    //DontDestroyOnLoad(gameObject);
}
void Update()
{
    if (pressing)
    {
           
            loja2.SetActive(false);
            selectclothes.SetActive(true);
            pressing = false;
        }

}
}



