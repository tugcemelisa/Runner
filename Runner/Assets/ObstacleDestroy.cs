using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDestroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Obstacle"))
        {
            Destroy(other.gameObject);
        }    
    }
}
