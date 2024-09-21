using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> locations = new List<GameObject>(); 
    [SerializeField] Transform player;
    [SerializeField] GameObject shield;
    float levelLength = 106.3f;
    int count = 15; 
    void Start()
    {
        Instantiate(locations[0], transform.forward, transform.rotation);
        for(int i = 0; i < count; i++)
        {
            CreateLocation();
        }
        GenerateObject();
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
    void GenerateObject()
    {
        float distance = Random.Range(100, 200);
        Instantiate(shield, player.position + new Vector3(0,2,distance), transform.rotation);
        Invoke("GenerateObject", Random.Range(20,30));
    }

    void Update()
    {
        if(player.position.z > levelLength - 106.3f * count)
        {
            CreateLocation();
            Time.timeScale += 0.1f;
        }
    }  
}
