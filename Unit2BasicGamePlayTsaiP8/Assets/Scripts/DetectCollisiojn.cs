using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisiojn : MonoBehaviour
{
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
       if (other.CompareTag("Animals"))
        {
            gameManager.AddScore(+5);
            Destroy(gameObject); 
            Destroy(other.gameObject); 
        }
    }

}
