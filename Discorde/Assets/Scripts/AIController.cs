using System;
using UnityEngine;

public class AIController : MonoBehaviour
{

    

    public float speed = 0.1f;
    public int jumpForce = 5;
    
    public Boolean touchingGrass = true;

    public GameObject player;

    public int bumpForce = 5;

    public int lives = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.speed = 1200f;
        this.jumpForce = 5;
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
        if (transform.position.y < -2.5f)
        {
            transform.position = new Vector3(0, 4f, 0);
            GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
            lives--;
        }
    }

    void FollowPlayer(){
        Vector3 playerPosition = player.transform.position;
        Vector3 aiPosition = transform.position;
        Vector3 direction = playerPosition - aiPosition;
        direction.Normalize();
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground"){
            touchingGrass = true;
        } else if (collision.gameObject.name == "PlayerSphere")
        {
            Rigidbody playerSphereRb = collision.gameObject.GetComponent<Rigidbody>();
            if (playerSphereRb != null && playerSphereRb.linearVelocity.magnitude < GetComponent<Rigidbody>().linearVelocity.magnitude)
            {
                
                bumpForce += 10;
                transform.localScale *= 1.1f;
            } else {
                this.speed += 500f;
            }
            playerSphereRb.AddForce(-collision.contacts[0].normal * bumpForce, ForceMode.Impulse);
        }
    }
}