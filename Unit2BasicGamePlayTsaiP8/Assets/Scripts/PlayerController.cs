using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10;
    public float zRange = 10;
    public float ZRange =  -16;
    public GameObject projectilePrefab;
    public Transform projectileSpawnPoint;
    private float sideBound = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);

        }
        if (transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);

        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        { 
        //Launch a projectile from the player
        Instantiate(projectilePrefab,projectileSpawnPoint.position, projectilePrefab.transform.rotation);
        }

        if (transform.position.z < ZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, ZRange );

        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange );

        }
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

           if (transform.position.x > sideBound)
        {
            Debug.Log("Game Over!"); Destroy(gameObject);
        }
         

    }



}
