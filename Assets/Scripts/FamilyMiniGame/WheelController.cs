using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelController : MonoBehaviour
{
    public BabyController babyControllerObj;
    public WheelView wheelViewObj;
    public Rigidbody2D babyRb;
    public float speed = 3.0f;
    //private bool touchStart = false;
    private Vector2 pointA;
    private Vector2 pointB;
    private float baseAngle = 0.0f;
    private float CircleCurrAngle = 0.0f;
    public bool resetRotation = false;
    public float bufferAngle = 0f;
    public bool RefreshAngleValue = false;
    //public Transform circle;
    void Update()
    { 
        babyRb.transform.Translate(Vector2.up * Time.deltaTime);
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
    //     if (resetRotation == false)
    //     {
    //         if (Input.GetMouseButtonDown(0))
    //         {
    //             Vector3 dir = Camera.main.WorldToScreenPoint(transform.position);
    //             dir = Input.mousePosition - dir;
    //             baseAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
    //             baseAngle -= Mathf.Atan2(transform.right.y, transform.right.x) * Mathf.Rad2Deg;
    //             CircleCurrAngle = babyControllerObj.GetPlayerZAxis();
    //         }
    //         if (Input.GetMouseButton(0))
    //         {
    //             var dir = Camera.main.WorldToScreenPoint(transform.position);
    //             dir = Input.mousePosition - dir;
    //             var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - baseAngle;
    //             Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    //             wheelViewObj.SetWheelRotation(rotation);
    //             //circle.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    //             //Debug.Log(angle);
    //             if (RefreshAngleValue == true)
    //             {
    //                 CircleCurrAngle+= 180f;
    //                 RefreshAngleValue = false;
    //             }
    //             babyControllerObj.UpdateRotation(angle + CircleCurrAngle + bufferAngle);
    //         }
    //         else
    //         {
    //             wheelViewObj.ResetWheelRotation();
    //             //circle.eulerAngles = new Vector3(0f, 0f, 0f);
    //             //touchStart = false;
    //         }
    //     }
    //     else
    //         resetRotation = false;

    // }
}
    

