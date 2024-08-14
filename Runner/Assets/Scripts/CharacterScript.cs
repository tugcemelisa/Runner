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
        Debug.Log(message); // Kullanýcýnýn mesajýný konsola yazdýrýr
        Debug.Log("Character's current position: " + transform.position); // Karakterin baþlangýç pozisyonunu konsola yazdýrýr
    }

    void Update()
    {
        // 'Space' tuþuna basýldýðýnda karakterin saldýrmasýný saðlar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }

        // Karakteri sola hareket ettirir, sadece x pozisyonu -9'dan büyükse
        if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -9)
        {
            transform.Translate(-9, 0, 0);
        }

        // Karakteri saða hareket ettirir, sadece x pozisyonu 9'dan küçükse
        if (Input.GetKeyDown(KeyCode.D) && transform.position.x < 9)
        {
            transform.Translate(9, 0, 0);
        }
    }

    void FixedUpdate()
    {
        // Karakterin ileri doðru sabit hýzda hareket etmesini saðlar
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }

    void Attack()
    {
        // Karakterin saldýrý kodu burada yer alýr
        Debug.Log("Karakter saldýrýyor!");
    }
}