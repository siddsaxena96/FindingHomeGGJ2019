using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public string sceneName;
    
    void OnCollisionEnter2D(Collision2D col)
    {
        SceneManager.LoadScene(sceneName);
    }
}
