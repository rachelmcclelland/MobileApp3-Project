using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int scoreValue = 10; // later

    public int ScoreValue { get { return scoreValue; } }

    // gets kicked off when transform gets hit by something
    //private void OnTriggerEnter2D(Collider2D collision)
    //{

    //}

}
