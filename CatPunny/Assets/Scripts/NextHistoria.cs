using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextHistoria : MonoBehaviour {



    public bool Last;
    public GameObject At;
    public GameObject Next;
    public GameObject Historia;
	void Start () {
		
	}
	

	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            
                At.SetActive(false);
                Next.SetActive(true);
            

            if (Last)
            {
                Historia.SetActive(false);
            }



        }

        }
}
