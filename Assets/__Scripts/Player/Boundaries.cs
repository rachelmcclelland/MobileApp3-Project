﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    public Camera mainCamera;

    private Vector2 screenBounds;
    private float objectWidth;
    // Start is called before the first frame update
    void Start()
    {
        screenBounds = mainCamera.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
                                                          mainCamera.transform.position.z));

        objectWidth = transform.GetComponent<SpriteRenderer>().bounds.extents.x;

    }

    private void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        // add the objectWidth to the min, subtract from the max
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x * -1 + objectWidth,
                                        screenBounds.x - objectWidth);
        transform.position = viewPos;


    }
}
