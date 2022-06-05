using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawnManager : MonoBehaviour
{

    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float spawnDelay = 0.1f;
    private float spawnRepeat = 0.45f;


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPostition = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spawnPostition, animalPrefabs[animalIndex].transform.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnRepeat );
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    
}
