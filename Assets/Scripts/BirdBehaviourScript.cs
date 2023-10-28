using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdBehaviourScript : MonoBehaviour

{
    public float force;

    public Rigidbody2D rb;
    public GameManagement gameManagement;

    void Start()
    {
        Debug.Log("Hello Flappy Bird");
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // LM click check
        {
            // Bird's fly controls
            rb.velocity = Vector2.up * force;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision) // Checks if the bird went through the pipes
    {
        if(collision.gameObject.name == "TriggerBox")
        {
            gameManagement.IncrementScore();
        }
    
    }

    private void OnCollisionEnter2D(Collision2D collision) // Checks if the bird collided with the "DeadEnd" tagged objects
    {
        if (collision.gameObject.tag == "DeadEnd")
        {
            Time.timeScale = 0;
        }
    }
}
