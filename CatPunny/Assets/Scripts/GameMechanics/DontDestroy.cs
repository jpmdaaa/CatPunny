using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DontDestroyOnLoad(gameObject);
        if(SceneManager.GetActiveScene()==SceneManager.GetSceneByName("menu")|| SceneManager.GetActiveScene() == SceneManager.GetSceneByName("loading") || SceneManager.GetActiveScene() == SceneManager.GetSceneByName("GameOver"))
            {
            gameObject.SetActive(false);
            }

    }
}
