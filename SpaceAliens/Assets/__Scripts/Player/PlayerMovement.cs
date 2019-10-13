﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField]
    private float moveSpeed = 10.0f;

    void Update()
    {
        Move();
    }

    private void Move()
    {
        // get a change in direction
        var deltaX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        //calculate a new x position
        var newXPos = transform.position.x + deltaX;

        transform.position = new Vector2(newXPos, transform.position.y);
    }

}
