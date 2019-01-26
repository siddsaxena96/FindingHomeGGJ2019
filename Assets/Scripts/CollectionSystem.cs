using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionSystem : MonoBehaviour
{

    #region ---------------------------Public Variables--------------------------
    public GameObject slider;
    #endregion
    private float nauseaValue = 0f;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Alcohol")
        {
            AlcoholCollection();
            Destroy(col.gameObject);
        }
        else if (col.gameObject.tag == "WaterBottle")
        {
            WaterBottleCollection();
            Destroy(col.gameObject);
        }
    }
    #region ---------------------------------Private Methods-------------------------------------
    private void AlcoholCollection()
    {
        if (nauseaValue < 1f)
        {
            nauseaValue += 0.1f;
        }
        slider.GetComponent<Slider>().value = nauseaValue;
    }

    private void WaterBottleCollection()
    {
        if (nauseaValue > 0f)
        {
            nauseaValue -= 0.1f;
        }
        slider.GetComponent<Slider>().value = nauseaValue;

    }
    #endregion
}
