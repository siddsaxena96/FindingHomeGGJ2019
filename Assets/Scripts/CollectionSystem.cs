using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionSystem : MonoBehaviour
{

    #region ---------------------------Public Variables--------------------------
    public GameObject slider;
    public GameObject hpText;
    public float maxHP = 3f;
    #endregion
    private float nauseaValue = 0f;
    private float hp;
    void Start()
    {
        hp = maxHP;
        slider.GetComponent<Slider>().value = nauseaValue;
        hpText.GetComponent<Text>().text = "Chances: " + hp;
    }
    void Update()
    {
        // hpText.GetComponent<Text>().text = "Chances: " + hp;
        Debug.Log(hp);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Platform")
            return;
        else if (col.gameObject.tag == "Alcohol")
        {
            AlcoholCollection();
        }
        else if (col.gameObject.tag == "WaterBottle")
        {
            WaterBottleCollection();
        }
        else if (col.gameObject.tag == "BrokenCollectibles")
        {
            Debug.Log("Damaged");
            DamagePlayer();
        }
        hpText.GetComponent<Text>().text = "Chances: " + hp;
        Destroy(col.gameObject);
    }
    public void DamagePlayer()
    {
        if (hp > 0f)
            hp -= 1f;
        else if (hp <= 0f)
        {
            //Fail();//reload scene
        }
        hpText.GetComponent<Text>().text = "Chances: " + hp;
    }
    #region ---------------------------------Private Methods-------------------------------------
    private void AlcoholCollection()
    {
        if (nauseaValue < 1f)
        {
            nauseaValue += 0.2f;
        }
        slider.GetComponent<Slider>().value = nauseaValue;
        if (nauseaValue >= 1f)
        {
            //Win();//next scene
        }
    }

    private void WaterBottleCollection()
    {
        if (nauseaValue > 0f)
        {
            nauseaValue -= 0.2f;
        }
        slider.GetComponent<Slider>().value = nauseaValue;
        if (hp <= maxHP)
        {
            hp += 1;
        }
    }
    #endregion
}
