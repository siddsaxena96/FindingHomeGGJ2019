using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerSingle : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;
    public GameObject enemyHoard;
    public Transform hoardPosition;
    public PlayerShooter shooter;
    public GameObject friend;
    public int score=0;
    private float waitTime=2f;
    public Text scoreText;
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
        Debug.Log("START");
        while (score<3)
        {
            yield return new WaitForSeconds(waitTime);
            for(int i=0;i<spawnPoints.Length;i++){
                if(Random.Range(0,2)==1){                  
                    Instantiate(enemy,spawnPoints[i].transform.position,Quaternion.identity);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        shooter.enabled=false;
        yield return new WaitForSeconds(4);
        GameObject hoardSpawn = Instantiate(enemyHoard,spawnPoints[2].transform.position,Quaternion.identity) as GameObject;
        Rigidbody2D hoardRb=hoardSpawn.GetComponent<Rigidbody2D>();
         while(Vector2.Distance(hoardSpawn.transform.position,hoardPosition.position)>2){
             hoardRb.velocity=(new Vector2(hoardPosition.position.x,hoardPosition.position.y)-hoardRb.position).normalized*5f;
            yield return new WaitForSeconds(0.1f);   
        }
        hoardRb.velocity=Vector2.zero;
        hoardSpawn.GetComponent<Animator>().enabled=true;
        yield return new WaitForSeconds(3);
        friend.SetActive(true);
    }
}
