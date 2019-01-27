using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShatterSound : MonoBehaviour
{
    public AudioSource shatter;
    public void PlayShatter()
    {
        shatter.Play();
    }
}
