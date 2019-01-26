using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public Transform playerPos;
   public Transform shootingPoint;

    void FixedUpdate()
    {
        Vector3 moveDirection = transform.position - playerPos.transform.position;         
        float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
        Debug.Log(angle);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);        
        shootingPoint.rotation=Quaternion.AngleAxis(angle, Vector3.forward);        
    }
}

