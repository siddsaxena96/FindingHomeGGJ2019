using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public bool levelEnd = false;
    public float speed;
    void Update()
    {
        if (levelEnd == false)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
