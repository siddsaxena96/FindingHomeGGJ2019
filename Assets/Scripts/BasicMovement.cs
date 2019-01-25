using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float thrust;
    public float fwdSpeed;
    public Vector3 jumpForce;
    public Animator walkingAnim;
    public GameObject floor;
    void Start()
    {
        rb = GetComponent<Rigidbody2D> ();
        jumpForce = new Vector3(0.0f, thrust, 0.0f);
    }
    
    void Update()
    {
        bool groundInst = floor.GetComponent<FloorBehave>().isGrounded;
        
        

        if(Input.GetKeyDown(KeyCode.Space) && groundInst == true )
        {

            rb.gravityScale = 1.0f;
            rb.AddForce(jumpForce);

        }

        if(groundInst == false)
        {
            rb.gravityScale = 10.0f;
        }

          else if(groundInst == true)
        {
            rb.gravityScale = 1.0f;

            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0);
            rb.velocity = movement * fwdSpeed;
        }


        if(rb.velocity==Vector2.zero){                 
            walkingAnim.Play("NONE");
        }
       /* else{
            walkingAnim.Play("Walking");
        }*/
    }
}
