using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> locations = new List<GameObject>();
    [SerializeField] Transform player;
    float levelLength = 106f;
    int count = 4;

    void Start()
    {
        Instantiate(locations[0], transform.forward, transform.rotation);
        for (int i = 0; i < count; i++)
        {
            CreateLocation();
        }
    }

    void CreateLocation()
    {
        Instantiate(locations[Random.Range(0, locations.Count)], transform.forward * levelLength, transform.rotation);
        levelLength += 106f;
    }

    void Update()
    {
        if (player.position.z > levelLength - 106f * count)
        {
            CreateLocation();
        }
    }
}