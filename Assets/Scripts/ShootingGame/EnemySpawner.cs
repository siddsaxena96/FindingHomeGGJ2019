using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;
    public int score=0;
    private float waitTime=2f;
    public Text scoreText;
    public GameObject loadingPanel;
    public AudioSource transitionAudio;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnEnemies");
    }

    public void UpdateScore(){
        score++;
        scoreText.text="Score : "+score;
    }
    
    private IEnumerator SpawnEnemies()
    {
        while (score<10)
        {
            yield return new WaitForSeconds(waitTime);
            for(int i=0;i<spawnPoints.Length;i++){
                if(Random.Range(0,2)==1){
                    Instantiate(enemy,spawnPoints[i].transform.position,Quaternion.identity);
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
        StartCoroutine("ReturnToRoad");
    }
    
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
