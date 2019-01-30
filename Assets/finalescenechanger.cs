using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalescenechanger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        Invoke("sceneloader", 4);
    }

    void sceneloader()
    {
        SceneManager.LoadScene("Credits");
    }
}
