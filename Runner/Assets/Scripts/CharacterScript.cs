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
    [SerializeField] GameObject shield;
    [SerializeField] GameObject itemVFX, shieldVFX, obstacleVFX;
    [SerializeField] AudioClip itemSFX, shieldSFX, obstacleSFX, destroySFX;
    [SerializeField] AudioSource sound, music;
    float roundScore;
    bool isGameOver;   
    bool isShield;
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
    void DeactivateShield()
    {
        isShield = false;        
    }
    
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Obstacle"))
        {
            if(isShield)
            {
                Destroy(other.gameObject);
                sound.clip = destroySFX;
                sound.Play();
            }
            else
            {
                isGameOver = true;            
                menu.SetActive(true);
                anim.SetBool("death", true);
                GameObject vfx = Instantiate(obstacleVFX, transform.position, transform.rotation);
                sound.clip = obstacleSFX;
                sound.Play();
                music.Stop();
                Destroy(vfx, 3f); 
            }            
        }        
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.CompareTag("Money"))
        {
            roundScore += 5;
            score.text = "Score: " + roundScore.ToString("f1"); 
            GameObject vfx = Instantiate(itemVFX, other.transform.position, other.transform.rotation);
            Destroy(vfx, 3f); 
            sound.clip = itemSFX;
            sound.Play(); 
            Destroy(other.gameObject);
        }
        if(other.CompareTag("Shield"))
        {
            isShield = true;
            Invoke("DeactivateShield", 5f);
            GameObject vfx = Instantiate(shieldVFX, transform.position + transform.up, other.transform.rotation);
            vfx.transform.SetParent(this.transform);
            sound.clip = shieldSFX;
            Destroy(vfx, 5f);
            sound.Play();               
            Destroy(other.gameObject);
        }
    }
}
