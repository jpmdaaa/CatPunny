// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Mute : MonoBehaviour, IPointerDownHandler
{

    public bool pressing;
    private AudioSource _as;



    void Awake()
    {
        DontDestroyOnLoad(this);
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }

    void Start()
    {
        _as = GetComponent<AudioSource>();
    }


    void Update()
    {
        if (pressing)
            _as.mute = !_as.mute;
    }
}