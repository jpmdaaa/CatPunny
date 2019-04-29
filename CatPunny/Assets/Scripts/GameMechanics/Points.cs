using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour {

    public static int points;
    public Text pointsTXT;
    public Text coinsTXT;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        pointsTXT.text = "Points: " + points.ToString();
        coinsTXT.text ="Coins: " + Player.money.ToString();
       
	}


}
