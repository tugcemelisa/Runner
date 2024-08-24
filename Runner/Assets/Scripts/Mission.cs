using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableExample : MonoBehaviour
{
    // 1. Define an integer variable and assign a value to it
    int myInt = 21;

    // 2. Define a decimal variable and assign a value to it
    float myDecimal = 3.14f;

    // 3. Define a string variable and assign it the value "Hello Kodland!"
    string myString = "Hello Kodland!";

    void Start()
    {
        // 4. Print the string variable to the console (only once)
        Debug.Log(myString);
    }

    void Update()
    {
        // 5. Print the integer variable to the console in every frame
        Debug.Log(myInt);
    }
}

