using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float countDownTimer = 5.0f;
    public Transform enemy1Prefab;
    public Transform enemy2Prefab;
    public Transform spawnLocation;

    private float time = 2.0f;
    private int waveIndex = 0;
    private float yieldTime = 20.0f;
    private float yieldTime2 = 80.0f;

    void Update()
    {
        if (time <= 0)
        {
            StartCoroutine(SpawnEnemyWave());
            StartCoroutine(SpawnEnemyWave2());
            time = countDownTimer;
        }

        time -= Time.deltaTime;
    }

    IEnumerator SpawnEnemyWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(yieldTime);
        }
    }

    IEnumerator SpawnEnemyWave2()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy2();
            yield return new WaitForSeconds(yieldTime2);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemy1Prefab, spawnLocation.position, spawnLocation.rotation);
    }

    void SpawnEnemy2()
    {
        Instantiate(enemy2Prefab, spawnLocation.position, spawnLocation.rotation);
    }
}
