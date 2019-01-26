using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public EnemySpawner enemySpawner;
    
    void Start(){
        enemySpawner=GameObject.Find("EnemySpawner").GetComponent<EnemySpawner>();
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag=="Laser")
            enemySpawner.UpdateScore();            
            Destroy(gameObject);
    }
}
