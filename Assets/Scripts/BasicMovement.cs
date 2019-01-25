using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float thrust=2f;
    public Animator walkingAnim;
    public bool move;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
    }
    
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3 (moveHorizontal, moveVertical,0 );
        if(move){
            rb.velocity = movement * thrust;
        }
        if(rb.velocity==Vector2.zero){                 
            walkingAnim.Play("NONE");
        }
        else{
            walkingAnim.Play("Walking");
        }
    }
}
