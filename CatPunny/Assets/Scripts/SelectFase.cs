

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;



 public class SelectFase : MonoBehaviour, IPointerDownHandler
{

    public bool pressing;
  
    public GameObject avtiveObj;
    public GameObject desactiveObj;
    
    public GameObject Player;
    /*
    public GameObject configs;
    public GameObject lifeUL;
    public GameObject Points;
    */

    public void OnPointerDown(PointerEventData eventData)
    {
        pressing = true;
    }



    void Start()
    {

        //DontDestroyOnLoad(gameObject);
        //Player.GetComponent<Player>().transform.position = new Vector2(0.91f, -0.035f);
        //Playerdog.GetComponent<Player>().transform.position = new Vector2(0.91f, -0.035f);

    }
    void Update()
    {
      
        Player.GetComponent<Player>().timer = 0;
        
        if (pressing)
        {

            avtiveObj.SetActive(true);
            desactiveObj.SetActive(false);
            Player.SetActive(false);
            //Points.SetActive(true);
            //lifeUL.SetActive(true);
            //configs.SetActive(true);
            pressing = false;
            Player.GetComponent<Player>().life = 3;

            
         
        }

    }
}






