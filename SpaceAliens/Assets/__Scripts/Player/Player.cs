using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities;

public class Player : MonoBehaviour
{
    public static int score = 0;

    // field attributes
    [SerializeField]
    private PlayerBullet bulletPrefab;

    [SerializeField]
    private float bulletSpeed = 5f;

    [SerializeField]
    private float firingRate = 0.4f;

    private GameObject bulletParent;

    [SerializeField]
    private AudioClip shootClip;

    private SoundController soundController;


    // Start is called before the first frame update
    void Start()
    {
        bulletParent = ParentUtils.GetBulletParent();

        soundController = SoundController.FindSoundController();

    }

    // Update is called once per frame
    void Update()
    {
        if(GameControlScript.health == 1)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //start shooting using InvokeRepeating again
                InvokeRepeating("Shoot", 0f, firingRate);
            }

            // check when they stop shooting
            if (Input.GetKeyUp(KeyCode.Space))
            {
                // stop shooting by using the CancelInvoke method
                CancelInvoke("Shoot");
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var starpoints = collision.GetComponent<StarPoints>();

        if(starpoints)
        {
            Destroy(starpoints.gameObject);
            Debug.Log(score);
            score += 10;
        }
    }

    private void Shoot()
    {
        PlayerBullet bullet = Instantiate(bulletPrefab, bulletParent.transform);

        // set position to player position(this.transform)
        bullet.transform.position = transform.position;

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * bulletSpeed; 

        if (soundController)
        {
            // play shot when player uses shoot button
            soundController.PlayOneShot(shootClip);
        }

    }
}
