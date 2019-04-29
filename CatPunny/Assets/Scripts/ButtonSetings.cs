using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonSetings : MonoBehaviour, IPointerDownHandler,IPointerUpHandler
{

    public GameObject buttonmute;
    public GameObject buttononmute;
    public GameObject buttonexit;
    public GameObject buttonsetings;
    public GameObject buttonexitgame;
    public GameObject buttonController;
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


    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if(pressing)

        {
            buttonsetings.SetActive(false);
            buttonexit.SetActive(true);
            buttononmute.SetActive(true);
            buttonmute.SetActive(true);
            buttonexitgame.SetActive(true);
            buttonController.SetActive(true);
            pressing = false;
        }
        
        	
	}
}
