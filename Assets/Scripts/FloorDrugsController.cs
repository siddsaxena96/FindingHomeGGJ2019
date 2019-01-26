using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorDrugsController : MonoBehaviour
{
    #region ---------------Public Variables-------------------------
    public GameObject waterBottle;
    public GameObject waterBottleBroken;
    public GameObject alcohol;
    public GameObject alcoholBroken;
    public CollectionSystem collectionSystem;
    #endregion
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
            return;
        Transform collisionLocation = col.transform;
        Debug.Log(collisionLocation);
        if (col.gameObject.tag == "Alcohol")
        {
            GameObject tempObj = Instantiate(alcoholBroken);
            tempObj.transform.position = collisionLocation.position;
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "WaterBottle")
        {
            GameObject tempObj = Instantiate(waterBottleBroken);
            tempObj.transform.position = collisionLocation.position;
            collectionSystem.DamagePlayer();
            Destroy(col.gameObject);
        }
    }
}
