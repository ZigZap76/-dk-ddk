using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShots : MonoBehaviour
{ 


    public float speed = 20f;

    void Start()
    { 

        GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;

    }

    private void Update()
    {
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {

        Destroy(gameObject);
        

    }
}