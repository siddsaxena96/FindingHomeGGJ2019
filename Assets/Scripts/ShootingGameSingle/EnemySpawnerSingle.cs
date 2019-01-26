using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemySpawnerSingle : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public GameObject enemy;
    public Rigidbody2D enemyHoard;
    public Transform hoardPosition;
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
          Debug.Log("YO");
        yield return new WaitForSeconds(2);
        GameObject hoardSpawn = Instantiate(enemyHoard.gameObject,spawnPoints[2].transform.position,Quaternion.identity) as GameObject;
        while(Vector2.Distance(hoardSpawn.transform.position,hoardPosition.position)>2){
            enemyHoard.velocity=(new Vector2(hoardPosition.position.x,hoardPosition.position.y)-enemyHoard.position).normalized*5f;
            yield return new WaitForSeconds(0.1f);   
        }

    }
}
