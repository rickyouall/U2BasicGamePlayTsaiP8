using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 25;
    private float startDelay = 2;
    private float spawnInterval = 1f;
    public float SpawnMinZ;
    public float SpawnMaxZ; 
    public float SpawnX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRightAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
     
    
    void SpawnRandomAnimal()
        {
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
            animalPrefabs[animalIndex].transform.rotation);
        }

    void SpawnLeftAnimal()
    { 
        int animalIndex = Random.Range(0, animalPrefabs.Length); Vector3 spawnPos = 
            new Vector3(-SpawnX, 0, Random.Range(SpawnMinZ, SpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation); 
    }

    void SpawnRightAnimal() 
    { 
        int animalIndex = Random.Range(0, animalPrefabs.Length); Vector3 spawnPos = 
            new Vector3(SpawnX, 0, Random.Range(SpawnMinZ, SpawnMaxZ)); 
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
