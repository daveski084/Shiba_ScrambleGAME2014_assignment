using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    
    public Transform itemPrefab;
    public Transform spawnLocation;
    public float maxTime = 60;
    public float minTime = 30;

    private float time;
    private float spawnTime;

    void Start()
    {
        SetRandomTime();
        time = minTime;
    }

    void FixedUpdate()
    {

        time += Time.deltaTime;

        if (time >= spawnTime)
        {
            SpawnObject();
            SetRandomTime();
        }

    }
    void SetRandomTime()
    {
        spawnTime = Random.Range(minTime, maxTime);
    }

    void SpawnObject()
    {
        time = 0;
        Instantiate(itemPrefab, spawnLocation.position, spawnLocation.rotation);
    }

}

