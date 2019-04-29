using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Loading2 : MonoBehaviour {

    // Use this for initialization

    public GameObject loadingScreen;
    public Slider slider;
    public Text progressText;   
public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(AsynchronousLoad(sceneIndex));
    }


   
IEnumerator AsynchronousLoad(int sceneIndex)
    {
      

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;

        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            // [0, 0.9] > [0, 1]
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            progressText.text = progress * 100f + "%";

           
            yield return null;
        }
    }
}
