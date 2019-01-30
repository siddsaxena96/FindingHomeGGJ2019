using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FirstScene : MonoBehaviour
{
    public Text ringBellInstruction;
    public AudioSource bell;
    private bool checkBell = false;



    void OnTriggerEnter2D(Collider2D col)
    {
        ringBellInstruction.text = "Press Space To Ring Bell";
        checkBell = true;
        GetComponent<BoxCollider2D>().enabled = false;
    }

    void Update()
    {
        if (checkBell)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                bell.Play();
                Invoke("LoadNextScene", 2);
            }
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene("FamilyFinale");
    }

}
