using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour {
    
    void Start()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }

    }

    void Update () {
		 
        
            /*
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (Advertisement.IsReady("rewardedVideo"))
            {
                Advertisement.Show("rewardedVideo");
            }
        }
        */

    }
}
