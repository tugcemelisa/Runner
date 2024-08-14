using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{    
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float shift;  
    [SerializeField] float jumpForce;  
    [SerializeField] Animator anim;   
   

    void Start()
    {      
        
    }     
    void Update() 
    {                   
        if(Input.GetKeyDown(KeyCode.A) && transform.position.x > -2)
        {
            transform.Translate(-shift, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.D) && transform.position.x < 2)
        {
            transform.Translate(shift, 0, 0);
        }


        if(Input.GetKeyDown(KeyCode.Space) && rb.velocity.y == 0)
        {
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);  
                              
        }
        if(rb.velocity.y > 0)   
        {
            anim.SetBool("jump", true);  
        }
        if(rb.velocity.y == 0)
        {
            anim.SetBool("jump", false); 
        }
       
        
    }
    void FixedUpdate()
    {
       rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);       
    }
   
}
