using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random_Spawn_Animals : MonoBehaviour
{
    public int spawnPosX = 17;
    public int spawnLocZ = 20;
    public GameObject[] animalPrefab;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnLocZ);
        Instantiate(animalPrefab[animalIndex], spawnPos, animalPrefab[animalIndex].transform.rotation);
    }

}
