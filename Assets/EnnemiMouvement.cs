using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EnnemiMouvement : MonoBehaviour
{
    private float h = 1;
    public Vector3 decal1 = new Vector3(0, 0, 0);
    public Transform bulletshouts;
    public float speed = 40f;
    public GameObject ennemy;
    public static int nbPlanes = 1;


    public void Fire()
    {
        Instantiate(bulletshouts, GetComponent<Transform>().position + decal1, Quaternion.identity);
       
    }


    //ksjdhfksdgfqjhfggfqkehrfzr
    void Start()
    {
        
        InvokeRepeating("Fire", 2.0f, 0.5f);

        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    //;kjsefhlksesfhhvlksehfkerqf


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "wall")
        {
            h = -h;
            GetComponent<Rigidbody2D>().velocity = Vector3.right * h * speed;

        }
        if (col.gameObject.tag == "bullet player")
            if (nbPlanes <= 2)
            {
                if (ennemy)
                {
                    if (ennemy.activeInHierarchy == false)
                    {
                        ennemy.SetActive(true);
                        nbPlanes++;
                        
                    }
                }
            }
            else
            {
                Destroy(gameObject);
            }
            
    }

}
       