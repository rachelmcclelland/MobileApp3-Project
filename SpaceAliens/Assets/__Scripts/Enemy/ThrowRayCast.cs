using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowRayCast : MonoBehaviour
{
    [SerializeField] private Transform eyeLine; // gun, eyes transform on the cactus
    [SerializeField] private LayerMask visibleObjects;
    [Range(1, 15)]
    [SerializeField] private float sightDistance = 3.0f;

    private GameObject enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyInSight();
    }

    private void EnemyInSight()
    {
        // throw raycast here
        var hit = Physics2D.Raycast(eyeLine.position,
                                    Vector2.right,
                                    sightDistance,
                                    visibleObjects);
        Debug.DrawRay(eyeLine.position,
                      Vector2.down * sightDistance,
                      Color.red);   // show visible raycast

        if (hit)
        {
            Debug.Log("See enemy");
            // if enemy is seen, then fire
            // use the transition between animations
            // add a condition to the transition between them
        }
        else
        {
        }

    }
}
