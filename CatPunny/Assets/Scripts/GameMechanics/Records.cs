using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Records : MonoBehaviour {

 
    public Text pointsTXT;
    public static int recorde;
    public int[] ranking;
    public int pointsat;
   
    void Start () {
        if(PlayerPrefs.HasKey("Record"))
        {
            recorde = PlayerPrefs.GetInt("Record");
        }
        else
        {
            PlayerPrefs.SetInt("Record", recorde);
        }

	}

	void Update () {
    




        if (recorde==0)
        {
            recorde = Points.points;
            ranking[0] = Points.points;
            PlayerPrefs.SetInt("Record", recorde);

        }

        else if(recorde>0 && Points.points > recorde)
        {
           
                recorde = Points.points;
            PlayerPrefs.SetInt("Record", recorde);


        }
    
        //pointsTXT.text = Points.points.ToString();
        pointsTXT.text = "Recorde: " +  recorde.ToString();

      
       
    }
}
