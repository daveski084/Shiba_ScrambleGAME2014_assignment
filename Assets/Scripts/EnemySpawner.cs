/***********************************************************************;
* Project            : Shiba Scramble
*
* Author             : David Gasinec
* 
* Student Number     : 101187910
*
* Date created       : 20/10/22
*
* Description        : Controls the spawning of enemy waves.
*
* Last modified      : 20/10/25
*
* Revision History   :
*
*Date        Author Ref    Revision (Date in YYYYMMDD format) 
*201024    David Gasinec        Created script. 
*
|**********************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/** Controlls waves of enemies and spawns them. */
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

    /** Spawns waves, using coroutinues so a delay can be added.*/
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

    /** Spawns enemies each wave. Adds a delay so they dont bunch together as much. */
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

    /**Spawns enemies. */
    void SpawnEnemy()
    {
        Instantiate(enemy1Prefab, spawnLocation.position, spawnLocation.rotation);
    }

    void SpawnEnemy2()
    {
        Instantiate(enemy2Prefab, spawnLocation.position, spawnLocation.rotation);
    }
}
