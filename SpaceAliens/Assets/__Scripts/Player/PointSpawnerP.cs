using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities; 

public class PointSpawnerP : MonoBehaviour
{
    [SerializeField]
    private GameObject pointstar;

    private float spawnDelay = 0.5f;
    private float spawnInterval = 1.5f;

    private IList<SpawnPoint> spawnPoints;

    private Stack<SpawnPoint> spawnStack;

    private GameObject starParent;

    // Start is called before the first frame update
    void Start()
    {
        starParent = ParentUtils.GetStarParent();
        spawnPoints = GetComponentsInChildren<SpawnPoint>();
        SpawnRepeating();
    }

    // Update is called once per frame
    private void SpawnRepeating()
    {
        spawnStack = ListUtils.CreateShuffleStack(spawnPoints);
        InvokeRepeating("Spawn", spawnDelay, spawnInterval);
    }

    private void Spawn()
    {
        if (spawnStack.Count == 0)
        {
            // reshuffle the stack again
            spawnStack = ListUtils.CreateShuffleStack(spawnPoints);
        }
        var spawnPoint = spawnStack.Pop();

        //var enemy = Instantiate(enemyPrefab); //adds to the hierachy base level
        var star = Instantiate(pointstar, starParent.transform);
        star.transform.position = spawnPoint.transform.position;
    }
}
