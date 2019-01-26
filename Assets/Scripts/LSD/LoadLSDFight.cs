using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLSDFight : MonoBehaviour
{
    public GameObject loadingPanel;
    public AudioSource transitionAudio;
    IEnumerator ReturnToRoad(){
        Debug.Log("ASAD");
        // loadingPanel.SetActive(true);      
        // transitionAudio.Play();
        // while(transitionAudio.isPlaying){  
        //     yield return new WaitForSeconds(0.05f);
        // }
        yield return new WaitForSeconds(0.05f);
        SceneManager.LoadScene("RoadAfterFight");     
    }
}
