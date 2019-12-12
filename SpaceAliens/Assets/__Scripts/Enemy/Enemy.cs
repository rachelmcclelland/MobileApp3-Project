using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{

    // notify the system when it dies.
    public delegate void EnemyKilled(Enemy enemy);

    public static EnemyKilled EnemyKilledEvent;

    [SerializeField]
    private AudioClip lostLifeClip;

    private SoundController soundController;

    void Start()
    {
        soundController = SoundController.FindSoundController();
    }


    void Update()
    {
        if(!GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }

        
    }

    // gets kicked off when transform gets hit by something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovement>(); // hit by player
        var playerbullet = collision.GetComponent<PlayerBullet>();

        if (player)
        {
            PublishEnemyKilledEvent();
            //SceneManager.LoadScene("GameOver"); // load game over page
            GameControlScript.health -= 1;
            if (soundController)
            {
                soundController.PlayOneShot(lostLifeClip);
            }
        }
        else if (playerbullet)
        {

            Destroy(playerbullet.gameObject);
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
