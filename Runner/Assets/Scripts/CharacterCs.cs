using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCs : MonoBehaviour
{
    // SerializeField attribute allows you to see and modify this variable in the Unity Inspector.
    [SerializeField] private string message;

    // Start is called before the first frame update
    void Start()
    {
        // This line outputs the content of the message variable to the console when the game starts.
        Debug.Log(message);
    }
}