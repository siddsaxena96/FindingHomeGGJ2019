using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameView gameViewObj;
    private int score = 0;
    private int lives = 3;

    public void ScoreIncrement()
    {
        score = score + 1;
        gameViewObj.UpdateScoreDisplay(score);
    }

    public void LifeDecrement()
    {
        lives = lives - 1;
        gameViewObj.UpdateLivesDisplay(lives);
        if (lives == 0)
        {
            gameViewObj.DisplayGameOver();
            Invoke("RestartGame", 3f);
        }
    }
	
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
