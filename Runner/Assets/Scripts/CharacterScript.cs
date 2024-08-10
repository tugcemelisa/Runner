using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{    
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed; 

    void Start()
    {      
        
    }     
    void Update() 
    {
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            transform.Translate(-9, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
        {
            transform.Translate(9, 0, 0);
        }

    }
    void FixedUpdate()
    {
       rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);       
    }
   
}
