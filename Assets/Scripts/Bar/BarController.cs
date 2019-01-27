using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BarController : MonoBehaviour
{
    public AudioSource barConversation;
    public BasicMovement playerControl;
    public GameObject messageBox;
    private bool spaceDisable=true;

    void Start(){
        StartCoroutine("checkPlay");
    }

    IEnumerator checkPlay(){
        while(barConversation.isPlaying){
            yield return new WaitForSeconds(0.15f);
        }
        playerControl.move=true;
        messageBox.SetActive(true);
        spaceDisable=false;
    }

    void Update(){
        if(!spaceDisable){
            if(Input.GetKey(KeyCode.Space)){
            //    SceneManager.LoadScene("BarScene");  
            }
        }
    }

}
