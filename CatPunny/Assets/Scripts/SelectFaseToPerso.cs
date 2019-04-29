using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

 public class SelectFaseToPerso : MonoBehaviour, IPointerDownHandler
{

    public bool pressing;

    public GameObject selectperso;
    public GameObject selectfase;




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

            selectperso.SetActive(true);
            selectfase.SetActive(false);
            pressing = false;

        }

    }



}






