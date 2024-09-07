using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{    
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float shift;  
    [SerializeField] float jumpForce;  
    [SerializeField] Animator anim; 
    [SerializeField] TMP_Text score;  
    [SerializeField] GameObject menu;
    float roundScore;
    bool isGameOver;   

    void Start()
    {         
             
    }     
    void Update() 
    {       
        if(!isGameOver)
        {    
            roundScore += Time.deltaTime;
            score.text = "Score: " + roundScore.ToString("f1");        
        
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
    }
    void FixedUpdate()
    {
        if(!isGameOver)
        {
            rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);       
        }
    }   
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            isGameOver = true;            
            menu.SetActive(true);
            anim.SetBool("death", true);
        }
    }
}
