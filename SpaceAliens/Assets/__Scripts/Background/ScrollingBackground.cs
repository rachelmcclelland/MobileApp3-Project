using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    // Reference: https://www.youtube.com/watch?v=je1ZHOn3my4
    public float speed = -1.7f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 offset = new Vector2(Time.time * speed, 0);

        //GetComponent<Renderer>().material.mainTextureOffset = offset;

       // rb.velocity = new Vector2(0, speed);
    }
}
