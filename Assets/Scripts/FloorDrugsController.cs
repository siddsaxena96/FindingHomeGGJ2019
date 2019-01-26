using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDrugsController : MonoBehaviour
{
    public GameObject waterBottle;
    public GameObject waterBottleBroken;
    public GameObject alcohol;
    public GameObject alcoholBroken;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            return;
        Transform collisionLocation = col.transform;
        Debug.Log(collisionLocation);
        if (col.gameObject.tag == "Alcohol")
        {
            Destroy(col.gameObject);
            Instantiate(alcoholBroken, collisionLocation);
        }
        else if (col.gameObject.tag == "WaterBottle")
        {
            Destroy(col.gameObject);
            Instantiate(waterBottleBroken, collisionLocation);
        }
    }
}
