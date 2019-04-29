using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmadilhaCorrente : MonoBehaviour {

    public Transform tr;

    public float velrotate;
    public bool update1;
    public bool update2;
    public bool update3;
    public bool update4;
    public ButtonPause pause;

    void Start () {
        tr = GetComponent<Transform>();
       
    }
	
	
	void Update () {
        if(!pause.paused)
        {
            if (Points.points >= 100 && update1)
            {
                velrotate += 1;
                update2 = true;
                update1 = false;


            }
            if (Points.points >= 200 && update2)
            {
                velrotate += 2;
                update3 = true;
                update2 = false;


            }
            if (Points.points >= 300 && update3)
            {
                velrotate += 3;
                update4 = true;
                update3 = false;
            }
            if (Points.points >= 400 && update4)
            {
                velrotate += 4;
                update4 = false;
            }


            tr.Rotate(Vector3.forward, velrotate);

        }


    }
}
