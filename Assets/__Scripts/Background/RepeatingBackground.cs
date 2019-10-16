using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D bgCollider;
    private float bgSize;

    // Start is called before the first frame update
    void Start()
    {
        bgCollider = GetComponent<BoxCollider2D>();
        bgSize = bgCollider.size.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bgSize)
        {
            RepeatBackground();
        }
    }

    private void RepeatBackground()
    {
        Vector2 offset = new Vector2(0, bgSize * 2f);
        transform.position = (Vector2)transform.position + offset;
    }
}
