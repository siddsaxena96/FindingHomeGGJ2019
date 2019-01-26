using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyView : MonoBehaviour
{
    public GameController gameControllerObj;
    public BabyController babyControllerObj;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Treat")
        {
            gameControllerObj.ScoreIncrement();
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Ghost")
        {
            Destroy(collision.gameObject);
            gameControllerObj.LifeDecrement();
        }
        if (collision.gameObject.tag == "Wall")
        {
            babyControllerObj.InvertRotation();
        }
    }
}