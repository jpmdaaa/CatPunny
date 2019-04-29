using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonPause : MonoBehaviour, IPointerDownHandler
{

    // Use this for initialization

    public bool pressing;
    public bool paused;
    public GameObject despause;
    private Player player;
    /*
    public GameObject select;
    public GameObject tutorial;
    */
    public void Start()
    {
        player = FindObjectOfType<Player>();
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;

    }
    void Update()
    {
        if (pressing)
        {
            // SceneManager.LoadScene(0);

            paused = true;
            despause.SetActive(true);
            gameObject.SetActive(false);
            player.estaAndando = false;

        }

    }
}



