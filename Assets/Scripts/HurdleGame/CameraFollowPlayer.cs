using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public Transform cameraTransform;
    public Transform playerTransform;
    public bool DisableFollow = false;
    void Update()
    {
        if (DisableFollow == false)
        {
            transform.position = playerTransform.position + new Vector3(4f, 2.5f, -10f);
        }
        else
        {
            transform.position = new Vector3(-91.2f, 34.5f, 0f);
        }
    }
}
