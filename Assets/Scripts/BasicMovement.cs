using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    #region ---------------------Public Variables----------------------------
    public float thrust = 2f;
    public Animator walkingAnim;
    public bool move;
    #endregion
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        // float moveVertical = Input.GetAxis ("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0, 0);
        if (move)
        {
            rb.velocity = movement * thrust;
        }
        if (rb.velocity == Vector2.zero)
        {
            walkingAnim.Play("NONE");
        }
        else
        {
            walkingAnim.Play("Walking");
        }
    }
}
