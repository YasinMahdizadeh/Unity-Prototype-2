using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xrange = 20f;
    private float firstDelay = 2f;
    private float delayInterval = 2.2f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimals", firstDelay, delayInterval);
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimals();
        }
    }

    void SpawnRandomAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-xrange, xrange), 0, 20);

        Instantiate(animalPrefabs[animalIndex],
            spawnPosition,
            animalPrefabs[animalIndex].transform.rotation);
    }
}
