using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameView : MonoBehaviour
{
    public GameObject gameOverPanel;
    public Text scoreText;
    public Text livesText;
    public void DisplayGameOver()
    {
        gameOverPanel.SetActive(true);
    }
    public void UpdateScoreDisplay(int score)
    {
        scoreText.text = score.ToString();
    }

    public void UpdateLivesDisplay(int lives)
    {
        livesText.text = lives.ToString();
    }
}
