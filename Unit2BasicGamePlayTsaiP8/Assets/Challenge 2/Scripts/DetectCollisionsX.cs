using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Animals"))
        {

            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }

}
