using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionSystem : MonoBehaviour
{

    #region ---------------------------Public Variables--------------------------
    public GameObject slider;
    public GameObject hpText;
    public GameObject girl;
    public float maxHP = 3f;
    #endregion
    private float drunkValue = 0f;
    private float hp;
    void Start()
    {
        hp = maxHP;
        slider.GetComponent<Slider>().value = drunkValue;
        hpText.GetComponent<Text>().text = "Chances: " + hp;
    }
    void Update()
    {
        SpriteRenderer renderer = girl.GetComponent<SpriteRenderer>();
        Color color = renderer.color;
        renderer.color = new Color(color.r, color.g, color.b, 1 - drunkValue);// = 255 / drunkValue;
        //hpText.GetComponent<Text>().text = "Chances: " + hp;
        //Debug.Log(hp);
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
            CustomGameManager.Instance.Fail();
        }
        hpText.GetComponent<Text>().text = "Chances: " + hp;
    }
    #region ---------------------------------Private Methods-------------------------------------
    private void AlcoholCollection()
    {
        if (drunkValue < 1f)
        {
            drunkValue += 0.2f;
        }
        slider.GetComponent<Slider>().value = drunkValue;
        if (drunkValue >= 1f)
        {
            //Win();//next scene
        }
    }

    private void WaterBottleCollection()
    {
        if (drunkValue > 0f)
        {
            drunkValue -= 0.2f;
        }
        slider.GetComponent<Slider>().value = drunkValue;
    }
    #endregion
}
