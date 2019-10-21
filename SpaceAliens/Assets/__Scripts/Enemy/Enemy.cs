using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    [SerializeField]
    private int scoreValue = 10; // later

    public int ScoreValue { get { return scoreValue; } }

    // notify the system when it dies.
    public delegate void EnemyKilled(Enemy enemy);

    public static EnemyKilled EnemyKilledEvent;


    // gets kicked off when transform gets hit by something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>(); // hit by player

        if (player) // player hits, then collect circles
        {
            PublishEnemyKilledEvent();
            Destroy(gameObject);
        }
    }

    // event for the system
    private void PublishEnemyKilledEvent()
    {
        // EnemyKilledEvent?.Invoke(this);
        if (EnemyKilledEvent != null)
        {
            EnemyKilledEvent(this);
        }
    }

}
