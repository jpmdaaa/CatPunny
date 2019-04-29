using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaseControll : MonoBehaviour {
/*
   
    public GameObject fase1;
    public GameObject fase2;
    public GameObject fase3;
    public GameObject fase4;


    public GameObject playerkat;
    public GameObject playerdog;

  
    public GameObject buttonfase2;
    public GameObject buttonfase3;
    public GameObject buttonfase4;
    public GameObject buttonfase5;
 


    public GameObject star1;
    public GameObject star2;
    public GameObject star3;


    public GameObject selectfase;


    public GameObject fase1star1;
    public GameObject fase1star2;
    public GameObject fase1star3;



    public GameObject fase2star1;
    public GameObject fase2star2;
    public GameObject fase2star3;

    public GameObject fase3star1;
    public GameObject fase3star2;
    public GameObject fase3star3;

    public GameObject fase4star1;
    public GameObject fase4star2;
    public GameObject fase4star3;

    public GameObject fase5star1;
    public GameObject fase5star2;
    public GameObject fase5star3;


    







    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(fase1.gameObject)
        {
            if (Points.points >= 1 )
            {
              
                star1.SetActive(true);
                fase1star1.SetActive(true);
                star2.SetActive(true);
                fase1star2.SetActive(true);
                star3.SetActive(true);
                fase1star3.SetActive(true);
            }

            if( Player.passoufase1)
            {
                fase1.SetActive(false);
                selectfase.SetActive(true);
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                buttonfase2.SetActive(true);
                playerkat.SetActive(false);
                playerdog.SetActive(false);
                Player.passoufase1 = false;
            }
        



        }

        if (fase2.gameObject)
        {
            if (Points.points > 5)
            {
                star1.SetActive(true);
                fase2star1.SetActive(true);
            }

            if (Points.points > 7)
            {
                star2.SetActive(true);
                fase2star2.SetActive(true);
            }
            if (Points.points > 9)
            {
                star3.SetActive(true);
                fase2star3.SetActive(true);
            }

            if (Points.points > 1    && Player.passoufase2)
            {
                fase1.SetActive(false);
                fase2.SetActive(false);
                selectfase.SetActive(true);
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                buttonfase3.SetActive(true);
                playerkat.SetActive(false);
                playerdog.SetActive(false);
                Player.passoufase2 = false;
            }


        }

        if (fase3.gameObject)
        {
            if (Points.points > 10)
            {
                star1.SetActive(true);
                fase3star1.SetActive(true);
            }

            if (Points.points > 11)
            {
                star2.SetActive(true);
                fase3star2.SetActive(true);
            }
            if (Points.points > 12)
            {
                star3.SetActive(true);
                fase3star3.SetActive(true);
            }

            if (Points.points > 1 && Player.passoufase3)
            {
                fase1.SetActive(false);
                fase2.SetActive(false);
                fase3.SetActive(false);
                selectfase.SetActive(true);
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                buttonfase4.SetActive(true);
                playerkat.SetActive(false);
                playerdog.SetActive(false);
                Player.passoufase3 = false;
            }


        }
       

        if (fase4.gameObject)
        {

            if (Points.points > 15)
            {
                star1.SetActive(true);
                fase4star1.SetActive(true);
            }

            if (Points.points > 16)
            {
                star2.SetActive(true);
                fase4star2.SetActive(true);
            }
            if (Points.points > 17)
            {
                star3.SetActive(true);
                fase4star3.SetActive(true);
            }

            if ( Player.passoufase4)
            {

                fase1.SetActive(false);
                fase2.SetActive(false);
                fase3.SetActive(false);
                fase4.SetActive(false);
                selectfase.SetActive(true);
                star1.SetActive(false);
                star2.SetActive(false);
                star3.SetActive(false);
                buttonfase5.SetActive(true);
                playerkat.SetActive(false);
                playerdog.SetActive(false);
                Player.passoufase4 = false;
            }
        }

    



    }
    */
}
