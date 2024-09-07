using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> locations = new List<GameObject>(); 
    [SerializeField] Transform player;
    float levelLength = 106.3f;
    int count = 50;   

    void Start()
    {
       Instantiate(locations[0], transform.forward, transform.rotation);
       for(int i = 0; i < count; i++)
       {
            CreateLocation();
       }
    }

    void CreateLocation()
    {
        Instantiate(locations[Random.Range(0, locations.Count)], transform.forward * levelLength, transform.rotation);
        levelLength += 106.3f;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Update()
    {
        if(player.position.z > levelLength - 106.3f * count)
        {
            CreateLocation();
        }
    }  
}
