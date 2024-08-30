using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    [SerializeField] List<string> friends = new List<string>();

    void Start()
    {
        friends.Add("Mike");
        friends.Add("Julia");  
        friends.Add("Georg"); 
        friends.Add("Angel");       

        for (var i = 0; i < 5; i++)
        { 
            print(friends[i]);
        }
    }
}
