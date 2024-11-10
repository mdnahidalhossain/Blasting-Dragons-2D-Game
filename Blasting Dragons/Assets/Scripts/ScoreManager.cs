using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText ;
    // public TextMeshProUGUI totalScoreText ; // Reference to your UI Text
    private int score; // Variable to hold the score

    private void Start()
    {
        score = 0; // Initialize score to 0
        UpdateScoreText(); // Update the UI at the start
    }

    // Method to add score
    public void AddScore(int points)
    {
        score += points; // Increase the score
        UpdateScoreText(); // Update the displayed score
    }

    // Method to update the score text
    private void UpdateScoreText()
    {
        // scoreText.text = "Score: " + score; // Display the score
        scoreText.text = "Score: " + score;
    }
}

