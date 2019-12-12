using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public Text time;
    public static float timeStart;
    Scene currentScene;
    string sceneName;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        // Create a temporary reference to the current scene.
        currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        sceneName = currentScene.name;
    }

    void Update()
    {
        StopWatchTimer();
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeStart);
        timer += Time.deltaTime;

        if (sceneName == "GameSceneL1")
        {
            if ((int)timer == 120)
            {
                SceneManager.LoadScene("GameSceneL2");
            }
        }
        else if (sceneName == "GameSceneL2")
        {
            if ((int)timer == 150)
            {
                SceneManager.LoadScene("GameSceneL3");
            }
        }

    }

    void StopWatchTimer()
    {
        //TimeSpan timeSpan = TimeSpan.FromSeconds(timeStart);
        timeStart += Time.deltaTime;
        //timerUI.text = "Timer: " + timeSpan.Minutes + " : " + timeSpan.Seconds;
       // Invoke("StopWatchTimer", 1.0f);
       // Debug.Log("Time: " + timeStart);


    }


}
