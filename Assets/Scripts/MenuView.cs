using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    public GameObject failUI;
    public GameObject completionUI;
    public Animator heart;

    private void Start()
    {
        failUI.SetActive(false);
        completionUI.SetActive(false);
    }
    #region -------Public Methods--------------------

    public void OnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //for next narration or somin
    public void OnNextClick()
    {
        SceneManager.LoadScene("HurdleGameScene");
    }
    public void Fail()
    {
        CustomGameManager.Instance.isPaused = true;
        failUI.SetActive(true);
    }
    public void Completion()
    {
        CustomGameManager.Instance.isPaused = true;
        heart.SetBool("EnemiesDefeated", true);
        completionUI.SetActive(true);
        StartCoroutine("NextLevel");
    }
    #endregion

    IEnumerator NextLevel()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("HurdleGameScene");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("HurdleGameScene");
        }
    }

}
