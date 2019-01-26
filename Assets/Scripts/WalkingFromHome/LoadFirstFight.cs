using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstFight : MonoBehaviour
{
    public GameObject loadingPanel;
    public AudioSource transitionAudio;
    
    void OnTriggerEnter2D(Collider2D col)
    {             
        StartCoroutine("LoadFirstFightLevel");
    }

    IEnumerator LoadFirstFightLevel(){
        loadingPanel.SetActive(true);      
        transitionAudio.Play();
        while(transitionAudio.isPlaying){  
            yield return new WaitForSeconds(0.05f);
        }
        yield return new WaitForSeconds(0.05f);
        SceneManager.LoadScene("ShootingGame");     
    }
}
