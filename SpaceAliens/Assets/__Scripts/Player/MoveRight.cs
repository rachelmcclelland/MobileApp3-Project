using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    [SerializeField] private GameObject parent;

    [SerializeField]
    private float moveSpeed = 10.0f;

    private void OnMouseDown()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        parent.transform.Translate(Vector3.right * 10 * Time.deltaTime);

    }
}
