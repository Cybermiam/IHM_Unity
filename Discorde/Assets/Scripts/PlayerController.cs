using System;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 0.1f;
    public int jumpForce = 5;

    public int bumpForce = 5;

    public int lives = 3;

    public Boolean touchingGrass = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.speed = 1500f;
        this.jumpForce = 5;

    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(movement * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && touchingGrass)
        {   
            touchingGrass = false;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (transform.position.y < -2.5f)
        {
            transform.position = new Vector3(0, 4f, 0);
            rb.linearVelocity = Vector3.zero;
            lives--;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground"){
            touchingGrass = true;
        } else if (collision.gameObject.name == "AISphere")
        {
            Rigidbody aiSphereRb = collision.gameObject.GetComponent<Rigidbody>();
            if (aiSphereRb != null && aiSphereRb.linearVelocity.magnitude < GetComponent<Rigidbody>().linearVelocity.magnitude)
            {
                
                bumpForce += 10;
                transform.localScale *= 1.1f;
            } else{
                this.speed += 500f;
                
            }
            aiSphereRb.AddForce(-collision.contacts[0].normal * bumpForce, ForceMode.Impulse);
        }
    }
}
