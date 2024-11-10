using UnityEngine;
using UnityEngine.SceneManagement; // For scene management

public class GameManager : MonoBehaviour
{
    public GameObject restartPanel; // Reference to the restart panel

    void Start()
    {
        restartPanel.SetActive(false); // Hide the restart panel at the start
    }

    public void PlayerDied()
    {
        // Show the restart panel when the player dies
        restartPanel.SetActive(true);
    }

    void Update()
    {
        // Restart the game when 'R' is pressed
        if (restartPanel.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
    }

    void RestartGame()
    {
        // Reload the current scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
