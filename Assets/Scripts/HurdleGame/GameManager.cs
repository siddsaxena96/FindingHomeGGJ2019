using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public PlayerIdleAnim animObj;
    public Rigidbody2D platformRb;
    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StopPlatform()
    {
        animObj.StopAllCoroutines();

    }
}
