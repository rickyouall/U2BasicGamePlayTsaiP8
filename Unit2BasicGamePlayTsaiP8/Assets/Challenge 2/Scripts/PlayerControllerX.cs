using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public Transform projectileSpawnPoint;
    private float startDelay = 2;
    private float spawnInterval = 3f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab,projectileSpawnPoint.position, dogPrefab.transform.rotation);
        }
 
    
    
    
    }
}

