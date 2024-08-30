//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//[SerializeField] List<GameObject> locations = new List<GameObject>();
//[SerializeField] Transform player;
//float levelLength = 106f;

//void Start()
//{
//Instantiate(locations[0], transform.forward, transform.rotation);
//   }

//void CreateLocation()
//{
//Instantiate(locations[Random.Range(0, locations.Count)], transform.forward * levelLength, transform.rotation);
//levelLength += 106f;
//    }

//void Update()
//{
//if (player.position.z > levelLength - 106f)
//{
//CreateLocation();
//        }
//   }
//}
