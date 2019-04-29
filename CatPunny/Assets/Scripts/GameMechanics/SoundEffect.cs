using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour {


    public static SoundEffect Instance;
    public AudioClip colidSound;
  
    public AudioClip buttonsound;
    public AudioClip pointSound;
    public AudioClip foodSound;
    public GameObject Music;
    
    // Use this for initialization
    void Awake () {
		if(Instance!=null)
        {
            Debug.LogError("existem instacias multiplas");
        }
        Instance = this;
      
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakecolidSound()
    {
        MakeSound(colidSound);
    }

 

    public void MakeButtonSound()
    {
       
            MakeSound(buttonsound);
        
      
    }

    public void MakepointSound()
    {
       
            MakeSound(pointSound);
    }

    public void MakeFoodSound()
    {
      
            MakeSound(foodSound);
    }

    private void MakeSound(AudioClip originalClip)
    {
        AudioSource.PlayClipAtPoint(originalClip, transform.position);
    }




}
