using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    private Vector2 lastVelocity;
    private Rigidbody2D rb;

    void Start()
    {
        this.rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        int i = Random.Range(1,3);
        if(i == 1)
        {
            if(collision.gameObject.tag == "rod")
                rb.AddForce(new Vector2(1000,1000));
        }
        if(i == 2)
        {
            if(collision.gameObject.tag == "rod")
                rb.AddForce(new Vector2(-1000,1000));
        }
    }
    
}