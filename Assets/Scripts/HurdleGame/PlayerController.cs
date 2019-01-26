using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameManager gameManagerObj;
    public Animator playerAnimatorObj;
    public float jumpPadThrust;
    public float jumpThrust;
    public float gravity;
    public Rigidbody2D playerRb;
    void Update()
    {
        if(Input.GetKeyDown("down"))
        {
            playerAnimatorObj.SetBool("isCrouch",true);
            playerAnimatorObj.enabled = false;
            playerRb.transform.eulerAngles = new Vector3(0f,0f,90f);
        
            playerRb.gravityScale = 10f;
        }
        if(Input.GetKeyUp("down"))
        {
            playerAnimatorObj.enabled = true;
            playerAnimatorObj.SetBool("isCrouch",false);
            playerRb.transform.eulerAngles = new Vector3(0f,0f,0f);
            playerRb.gravityScale = gravity;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Floor" && Input.GetKey("up"))
        {
            Debug.Log("player velocity"+playerRb.velocity);
            if(playerRb.velocity==Vector2.zero)
            {
                Debug.Log("player velocity 0");
                playerRb.AddForce(Vector2.up*jumpThrust,ForceMode2D.Impulse);
            }
            //playerRb.gravityScale = 1f;
        }
        if(collision.gameObject.tag == "Hurdle")
        {
            gameManagerObj.ReloadCurrentScene();
        }
        if(collision.gameObject.tag == "JumpPad")
        {
            playerRb.AddForce(Vector2.up * jumpPadThrust,ForceMode2D.Impulse);
        }
    }
}
