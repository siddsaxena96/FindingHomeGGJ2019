using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesView : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject dogPrefab;
    public GameObject ratPrefab;
    public void InitSpawn(float RandomX, float RandomY)
    {
        Spawn(ObstacleType.DOG, RandomX, RandomY);

    }
    public void Spawn(ObstacleType obstacleObj, float RandomX, float RandomY)
    {
        if (obstacleObj == ObstacleType.DOG)
        {
            GameObject dog = Instantiate(dogPrefab, new Vector3(RandomX, RandomY, 0), Quaternion.identity);
            ObstacleModel model = dog.AddComponent<ObstacleModel>();
            model.type = obstacleObj;

        }
        else if (obstacleObj == ObstacleType.RAT)
        {
            GameObject rat = Instantiate(ratPrefab, new Vector3(RandomX, RandomY, 0), Quaternion.identity);
            ObstacleModel model = rat.AddComponent<ObstacleModel>();
            model.type = obstacleObj;
        }

    }
}
