using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spiski : MonoBehaviour
{
    [SerializeField] List<string> friends = new List<string>();

    void Start()
    {
        friends.Add("Tugce");
        friends.Add("Melisa");
        friends.Add("Taha");
        friends.Add("Holmes");

        // Loop to print the friends' names
        for (var i = 0; i < friends.Count; i++)
        {
            print(friends[i]);
        }

        // Loop to print numbers from 0 to 20
        for (int i = 0; i <= 20; i++)
        {
            print(i);
        }
    }
}



//public class Spiski : MonoBehaviour
//{
//  [SerializeField] List<string> friends = new List<string>();

//void Start()
//{
//friends.Add("Melisa");
//friends.Add("Tugce");
//friends.Add("Taha");
//friends.Add("Holmes");
//print(friends);
//System.Collections.Generic.List`1[System.String]

//print(friends[0]); // Melisa
//print(friends[3]); // Holmes
//print(friends[4]); // Error: ArgumentOutOfRangeException: Index was out of range. 
//   }
//}