using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayResults : MonoBehaviour
{
    [SerializeField] private Text timeUI;
    
    // Start is called before the first frame update
    void Start()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(Timer.timeStart);
        //timeUI.text = "Time: " + Timer.timeStart;
        timeUI.text = "Timer: " + timeSpan.Minutes + " : " + timeSpan.Seconds;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
