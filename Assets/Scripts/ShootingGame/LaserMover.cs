using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMover : MonoBehaviour
{
    private Rigidbody2D laserRb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        laserRb=GetComponent<Rigidbody2D>();
        laserRb.velocity = transform.right * speed;

    }

    void OnCollisionEnter2D(Collision2D col)
    {        
        Destroy(gameObject);
    }
}
