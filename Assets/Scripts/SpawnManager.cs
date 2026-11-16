using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 24f;
    private float spawnRangeZ = 24f;
    private float spawnPosY = 80;
    public GameObject[] collectablePrefabs;

    private float startDelay = 2;
    private float spawnInterval = 1;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCollectable", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomCollectable()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
        spawnPosY,Random.Range(-spawnRangeZ, spawnRangeZ));

        int itemIndex = Random.Range(0, collectablePrefabs.Length);
        
        Instantiate(collectablePrefabs[itemIndex],spawnPos,
        collectablePrefabs[itemIndex].transform.rotation);

    }
}
