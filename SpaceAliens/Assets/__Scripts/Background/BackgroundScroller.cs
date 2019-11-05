using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [SerializeField] private float scrollSpeed = 1.0f;
    private Vector2 offset; // use in update
    private Material myMaterial;

    void Start()
    {
        // get the material and set the offset value
        myMaterial = GetComponent<Renderer>().material;
        offset = new Vector2(0, scrollSpeed);
    }

    void Update()
    {
        // set the x offset
        myMaterial.mainTextureOffset +=
                            offset * Time.deltaTime;
    }
}
