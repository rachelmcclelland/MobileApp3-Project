using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private GameObject parent;


    private void OnMouseDown()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        // moves the player to the left
        parent.transform.Translate(Vector3.left * 10 * Time.deltaTime);

    }
}
