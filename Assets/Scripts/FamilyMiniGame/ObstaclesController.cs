using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesController : MonoBehaviour
{
    public ObstaclesView obstaclesViewObj;
    float nextSpawnRats = 0.0f;
    float nextSpawnDogs = 0.0f;
    void Start()
    {
        for (int i = 0; i < 3; i++)
        {
            float RandomX = Random.Range(-4, 5);
            float RandomY = Random.Range(-4, 5);
            //Debug.Log(10*(Mathf.Clamp(0.3f,0f,3f)));
            obstaclesViewObj.InitSpawn(RandomX*1.6f,RandomY*1.6f);
        }
    }
    void Update()
    {
        bool screenFull = false;
        int Ctr = 0;
        float spawnPointX = -100;
        float spawnPointY = -100; 
        List<float> spawnPointsXList = new List<float>();
        List<float> spawnPointsYList = new List<float>();
        if(Time.time > nextSpawnRats && Ctr < 10)
        {
            Ctr = 0;
            while(spawnPointsXList.IndexOf(spawnPointX) < 0 && spawnPointsYList.IndexOf(spawnPointY) < 0 && Ctr < 9)
            {    
                Ctr++;
                int RandomX = Random.Range(-4, 5);
                int RandomY = Random.Range(-3, 3);
                spawnPointX = RandomX * 1.6f;
                spawnPointY = RandomY * 1.6f;
                spawnPointsXList.Add(spawnPointX);
                spawnPointsYList.Add(spawnPointY);
                nextSpawnRats = Time.time + 2f;
                obstaclesViewObj.Spawn(ObstacleType.RAT,spawnPointX,spawnPointY);
            }
        }
        if(Time.time > nextSpawnDogs)
        {
            Ctr = 0;
            while(spawnPointsXList.IndexOf(spawnPointX) < 0 && spawnPointsYList.IndexOf(spawnPointY) < 0 && Ctr < 9)
            {    
                Ctr++;
                int RandomX = Random.Range(-4, 5);
                int RandomY = Random.Range(-3, 3);
                spawnPointX = RandomX * 1.6f;
                spawnPointY = RandomY * 1.6f;
                spawnPointsXList.Add(spawnPointX);
                spawnPointsYList.Add(spawnPointY);
                nextSpawnDogs = Time.time + 10f;
                obstaclesViewObj.Spawn(ObstacleType.DOG,spawnPointX,spawnPointY);
            }
        }
    }
}
