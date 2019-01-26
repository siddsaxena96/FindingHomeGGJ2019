using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    public GameObject failUI;
    private void Start()
    {
        failUI.gameObject.SetActive(false);
    }
    #region -------Public Methods--------------------

    public void OnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //for next narration or somin
    public void OnContinueClick()
    {

    }
    public void Fail()
    {
        CustomGameManager.Instance.isPaused = true;
        failUI.gameObject.gameObject.SetActive(true);
    }
    #endregion

}
