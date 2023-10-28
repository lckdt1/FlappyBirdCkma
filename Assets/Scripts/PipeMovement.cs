using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 6f);
    }
    // Update is called once per frame
    void FixedUpdate()
    {  
        transform.position += speed * Vector3.left * Time.deltaTime; 
    }
}
