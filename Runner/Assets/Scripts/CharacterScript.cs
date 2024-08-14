using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] private string message;
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;

    void Start()
    {
        Debug.Log(message); // Kullan�c�n�n mesaj�n� konsola yazd�r�r
        Debug.Log("Character's current position: " + transform.position); // Karakterin ba�lang�� pozisyonunu konsola yazd�r�r
    }

    void Update()
    {
        // 'Space' tu�una bas�ld���nda karakterin sald�rmas�n� sa�lar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        // Karakteri sola hareket ettirir, sadece x pozisyonu -9'dan b�y�kse
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            transform.Translate(-9, 0, 0);
        }

        // Karakteri sa�a hareket ettirir, sadece x pozisyonu 9'dan k���kse
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
        {
            transform.Translate(9, 0, 0);
        }
    }

    void FixedUpdate()
    {
        // Karakterin ileri do�ru sabit h�zda hareket etmesini sa�lar
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }

    void Attack()
    {
        // Karakterin sald�r� kodu burada yer al�r
        Debug.Log("Karakter sald�r�yor!");
    }
}