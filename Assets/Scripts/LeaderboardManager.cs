using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{
   

    public Text scoreText;
    public Text highScoreText;

    private int score = 0;
    private int highScore = 0;
    private string highScoreKey = "HighScore";

    
    void Start()
    {
        highScore = PlayerPrefs.GetInt(highScoreKey, 0);
        UpdateHighScoreUI();
        
    }
    
    void Update()
    {
        // Example: Update score text UI
        scoreText.text = "Score: " + score.ToString();

       

    }
  


    // Method to update the score
    public void UpdateScore(int newScore)
    {
        score = newScore;
        UpdateScoreUI();
        
        UpdateHighScoreUI(); // Check and update high score whenever score changes
    }

    // Method to update the score UI
    private void UpdateScoreUI()
    {
       
        scoreText.text = "Score: " + score.ToString();
    }

    // Method to update the high score UI
    private void UpdateHighScoreUI()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt(highScoreKey, highScore);
            PlayerPrefs.Save();
        }

        highScoreText.text = "High Score: " + highScore.ToString();
    }
}
