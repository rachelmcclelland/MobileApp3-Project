using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    public Text time;
    public static float timeStart;

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        StopWatchTimer();
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
