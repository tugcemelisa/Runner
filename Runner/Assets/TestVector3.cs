using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVector3 : MonoBehaviour
{
    Vector3 objectPosition;
   
    void Start()
    {
        objectPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        print(objectPosition);
    }

}
