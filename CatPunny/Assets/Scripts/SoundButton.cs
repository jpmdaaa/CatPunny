// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class SoundButton : MonoBehaviour, IPointerDownHandler
{

    public bool pressing;

    public SoundEffect somefeitos;


    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }



    void Start()
    {
        //DontDestroyOnLoad(gameObject);
    }
    void Update()
    {
        if (pressing)
        {

            somefeitos.MakeButtonSound();
            pressing = false;


        }

    }
}






