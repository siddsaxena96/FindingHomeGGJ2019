using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadFirstFight : MonoBehaviour
{
    public GameObject loadingPanel;
    public AudioSource transitionAudio;
    public BasicMovement player;
    
    void OnTriggerEnter2D(Collider2D col)
    {             
        player.move=false;
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
