using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviourSingle : MonoBehaviour
{
 public EnemySpawnerSingle enemySpawner;
    
    void Start(){
        enemySpawner=GameObject.Find("EnemySpawner").GetComponent<EnemySpawnerSingle>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Laser")
            enemySpawner.UpdateScore();            
            Destroy(gameObject);
    }
}
