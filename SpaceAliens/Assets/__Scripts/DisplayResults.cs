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
        timeUI.text += " " + Player.score;
    }

}
