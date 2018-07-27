using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerShots : MonoBehaviour
{

    // Use this for initialization
    public float speed = 150f;

    void Start()
    {

        GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;

        
    }
    private void Update()
    {
        Destroy(gameObject, 2);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
       Destroy(gameObject);
       

    }
}
        