// Mutes-Unmutes the sound from this object each time the user presses space.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class RemoveRoupa : MonoBehaviour, IPointerDownHandler
{


   



    public BuyIten btnroupa1;
    public BuyIten btnroupa2;
    public BuyIten btnroupa3;
    public BuyIten btnroupa4;
    public BuyIten btnroupa5;
    public BuyIten btnroupa6;
    public BuyIten btnroupa7;
    public BuyIten btnroupa8;
    public BuyIten btnroupa9;
    public BuyIten btnroupa10;
    public BuyIten btnroupa11;
    public BuyIten btnroupa12;


    public GameObject DogRoup1;
    public GameObject DogRoup2;
    public GameObject DogRoup3;
    public GameObject DogRoup4;
    public GameObject DogRoup5;
    public GameObject DogRoup6;
    public GameObject DogRoup7;
    public GameObject DogRoup8;
    public GameObject DogRoup9;
    public GameObject DogRoup10;
    public GameObject DogRoup11;
    public GameObject DogRoup12;



    public GameObject KatRoup1;
    public GameObject KatRoup2;
    public GameObject KatRoup3;
    public GameObject KatRoup4;
    public GameObject KatRoup5;
    public GameObject KatRoup6;
    public GameObject KatRoup7;
    public GameObject KatRoup8;
    public GameObject KatRoup9;
    public GameObject KatRoup10;
    public GameObject KatRoup11;
    public GameObject KatRoup12;



    public GameObject katremovegame1;
    public GameObject katremovegame2;
    public GameObject katremovegame3;
    public GameObject katremovegame4;
    public GameObject katremovegame5;
    public GameObject katremovegame6;
    public GameObject katremovegame7;
    public GameObject katremovegame8;
    public GameObject katremovegame9;
    public GameObject katremovegame10;
    public GameObject katremovegame11;
    public GameObject katremovegame12;



    public GameObject dogremovegame1;
    public GameObject dogremovegame2;
    public GameObject dogremovegame3;
    public GameObject dogremovegame4;
    public GameObject dogremovegame5;
    public GameObject dogremovegame6;
    public GameObject dogremovegame7;
    public GameObject dogremovegame8;
    public GameObject dogremovegame9;
    public GameObject dogremovegame10;
    public GameObject dogremovegame11;
    public GameObject dogremovegame12;













    public bool pressing;


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

            if(btnroupa1.comprado)
            {
                btnroupa1.activeselect.SetActive(true);
            }


            if (btnroupa2.comprado)
            {
                btnroupa2.activeselect.SetActive(true);
            }

            if (btnroupa3.comprado)
            {
                btnroupa3.activeselect.SetActive(true);
            }

            if (btnroupa4.comprado)
            {
                btnroupa4.activeselect.SetActive(true);
            }

            if (btnroupa5.comprado)
            {
                btnroupa5.activeselect.SetActive(true);
            }

            if (btnroupa6.comprado)
            {
                btnroupa6.activeselect.SetActive(true);
            }

            if (btnroupa7.comprado)
            {
                btnroupa7.activeselect.SetActive(true);
            }
            if (btnroupa8.comprado)
            {
                btnroupa8.activeselect.SetActive(true);
            }
            if (btnroupa9.comprado)
            {
                btnroupa9.activeselect.SetActive(true);
            }
            if (btnroupa10.comprado)
            {
                btnroupa10.activeselect.SetActive(true);
            }

            if (btnroupa11.comprado)
            {
                btnroupa11.activeselect.SetActive(true);
            }

            if (btnroupa12.comprado)
            {
                btnroupa12.activeselect.SetActive(true);
            }









            DogRoup1.SetActive(false);
            DogRoup2.SetActive(false);
            DogRoup3.SetActive(false);
            DogRoup4.SetActive(false);
            DogRoup5.SetActive(false);
            DogRoup6.SetActive(false);
            DogRoup7.SetActive(false);
            DogRoup8.SetActive(false);
            DogRoup9.SetActive(false);
            DogRoup10.SetActive(false);
            DogRoup11.SetActive(false);
            DogRoup12.SetActive(false);



            KatRoup1.SetActive(false);
            KatRoup2.SetActive(false);
            KatRoup3.SetActive(false);
            KatRoup4.SetActive(false);
            KatRoup5.SetActive(false);
            KatRoup6.SetActive(false);
            KatRoup7.SetActive(false);
            KatRoup8.SetActive(false);
            KatRoup9.SetActive(false);
            KatRoup10.SetActive(false);
            KatRoup11.SetActive(false);
            KatRoup12.SetActive(false);

            katremovegame1.SetActive(false);
            katremovegame2.SetActive(false);
            katremovegame3.SetActive(false);
            katremovegame4.SetActive(false);
            katremovegame5.SetActive(false);
            katremovegame6.SetActive(false);
            katremovegame7.SetActive(false);
            katremovegame8.SetActive(false);
            katremovegame9.SetActive(false);
            katremovegame10.SetActive(false);
            katremovegame11.SetActive(false);
            katremovegame12.SetActive(false);



            dogremovegame1.SetActive(false);
            dogremovegame2.SetActive(false);
            dogremovegame3.SetActive(false);
            dogremovegame4.SetActive(false);
            dogremovegame5.SetActive(false);
            dogremovegame6.SetActive(false);
            dogremovegame7.SetActive(false);
            dogremovegame8.SetActive(false);
            dogremovegame9.SetActive(false);
            dogremovegame10.SetActive(false);
            dogremovegame11.SetActive(false);
            dogremovegame12.SetActive(false);



            pressing = false;


        }

    }
}






