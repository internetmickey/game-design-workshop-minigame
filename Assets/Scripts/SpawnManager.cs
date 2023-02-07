using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefabs;
    private float spawnDelay = 2.0f;
    private float spawnInterval = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnemySpawner", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnemySpawner()
    {
        Vector3 spawnPos = new Vector3(26, 10, 5);
        Instantiate(enemyPrefabs, spawnPos, Quaternion.identity);
    }
}
