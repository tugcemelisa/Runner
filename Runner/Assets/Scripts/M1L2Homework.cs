using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello : MonoBehaviour
{
    float x = 0.5f; // 'f' suffix for float
    int y = 1;
    double z = 15;

    string hello = "Hello, world!";

    private void Start()
    {
        print(hello);
    }

    void Update()
    {
        // Your update logic here
    }
}