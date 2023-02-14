using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obbyPrefabs;
    private float spawnDelay = 2.0f;
    private float spawnInterval;
   
    // Start is called before the first frame update
    void Start()
    {
        float spawnInterval =  Random.Range(1, 4);
        InvokeRepeating("EnemySpawner", spawnDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void EnemySpawner()
    {
        int obbyIndex = Random.Range(0, obbyPrefabs.Length);
        Vector3 spawnPos = new Vector3(26, 0, 5); // set initial spawn position
        GameObject obby = Instantiate(obbyPrefabs[obbyIndex], spawnPos, Quaternion.identity);

        // get the height of the wall prefab and adjust the spawn position
        float height = obby.GetComponent<Renderer>().bounds.size.y;
        spawnPos.y = height / 2f; // adjust the Y coordinate to center the object

        obby.transform.position = spawnPos;
        spawnInterval = Random.Range(2, 4); // generate a new random interval
        CancelInvoke("EnemySpawner"); // cancel the current invocation
        InvokeRepeating("EnemySpawner", spawnInterval, spawnInterval); // invoke again with new interval
        
    }
}
