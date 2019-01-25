using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBehave : MonoBehaviour
{

    public bool isGrounded = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if(collision.gameObject.tag=="Player")
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {

            isGrounded = false;
        }
    }
}
