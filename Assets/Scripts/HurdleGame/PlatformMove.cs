﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed *Time.deltaTime);
    }
}
