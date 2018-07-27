using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class racket1 : MonoBehaviour
{
    public GameObject game;
    public Transform bullet;
    public bool loaded;
    public Vector3 decal = new Vector3(0, 0.219f, 0);



    private void Start()
    {
        Screen.SetResolution(640, 480, true, 60);
    }

    public void Fire()
    {
        if (loaded)
        {
            Instantiate(bullet, GetComponent<Transform>().position + decal, Quaternion.identity);
            StartCoroutine(Reloading());
        }
    }

    private IEnumerator Reloading()
    {
        loaded = false;
        yield return new WaitForSeconds(0.2f);
        loaded = true;

    }


    // Update is called once per frame
    public float speed = 150;
    public int health;

    void FixedUpdate()
    {
        float f = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * f * speed;
        if (Input.GetKeyDown("space"))
        {
            Fire();
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "bullet ennemy")
        {


            health--;
            if (health == 0)
            {
                Destroy(gameObject);
                game.SetActive(true);
            }
        }


    }
}


