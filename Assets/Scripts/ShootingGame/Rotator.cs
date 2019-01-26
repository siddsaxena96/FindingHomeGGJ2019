using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
   public Transform playerPos;
   public Transform shootingPoint;
   public Transform gun;
    void FixedUpdate()
    {
        Vector3 moveDirection = transform.position - playerPos.transform.position;         
        float angle =Mathf.Clamp(Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg,-90f,90f);
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);        
        shootingPoint.rotation=Quaternion.AngleAxis(angle, Vector3.forward);        
        gun.rotation=Quaternion.AngleAxis(angle, Vector3.forward);        
    }
}

