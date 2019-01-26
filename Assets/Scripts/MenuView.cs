using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuView : MonoBehaviour
{
    #region -------Public Method--------------------
    public GameObject retryButton;
    public void OnRetryClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    //for next narration or somin
    public void OnContinueClick()
    {

    }
    #endregion
    private void Start()
    {
        retryButton.gameObject.SetActive(false);
    }
}
