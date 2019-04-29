using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeMode : MonoBehaviour {


    public GameObject CenaAt;
    public GameObject Cenanxt;
    public FixedTouchField touchfield;
    public string ladotouch;

    // Use this for initialization
    void Start () {
     
      
    }

    // Update is called once per frame
    void Update()
    {
        if(ladotouch=="esquerda")
        {
            if (touchfield.TouchDist.x > 0)
            {
                CenaAt.SetActive(false);
                Cenanxt.SetActive(true);
                touchfield.Pressed = false;
            }
        }
        //Debug.Log(touchfield.TouchDist.x);

        if (ladotouch == "direita")
        {
            if (touchfield.TouchDist.x < 0)
            {
                CenaAt.SetActive(false);
                Cenanxt.SetActive(true);
                touchfield.Pressed = false;
            }
        }
    }

}
