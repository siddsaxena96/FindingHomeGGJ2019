using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    void Update()
    {
        transform.position = playerTransform.position + new Vector3(4f,2.5f,-10f); 
    }
}
