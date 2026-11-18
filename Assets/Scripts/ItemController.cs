using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomCollectable()
    {
        int objectIndex = Random.Range(0, 3);
        Instantiate(enemyPrefabs[objectIndex]);


    }
}
