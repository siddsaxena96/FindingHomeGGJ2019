using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyController : MonoBehaviour
{
    public Rigidbody2D babyRb;
    public float speed;
    void Update()
    { 
        babyRb.transform.Translate(Vector2.up * Time.deltaTime * speed);
        if (Input.GetKey("w"))
        {
            babyRb.transform.eulerAngles = new Vector3(0f,0f,0f);
        }
        if (Input.GetKey("a"))
        {
            babyRb.transform.eulerAngles = new Vector3(0f,0f,90f);
        }
        if (Input.GetKey("s"))
        {
            babyRb.transform.eulerAngles = new Vector3(0f,0f,180f);
        }
        if (Input.GetKey("d"))
        {
            babyRb.transform.eulerAngles = new Vector3(0f,0f,-90f);
        }

    }   
    public void InvertRotation()
    {
        float curAngle = babyRb.transform.eulerAngles.z;
        babyRb.transform.eulerAngles = new Vector3(0f,0f,180f+curAngle);
    } 
    
}
    

