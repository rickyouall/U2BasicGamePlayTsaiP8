using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 2;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;


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
        int animalIndex = Random.Range(0, ballPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        Instantiate(ballPrefabs[animalIndex], spawnPos,
        ballPrefabs[animalIndex].transform.rotation);
    }

}
