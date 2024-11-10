using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnDestroy : MonoBehaviour
{

    public GameObject restartPanel; 

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 4.5)
        {
            // SceneManager.LoadScene(0);
            ShowRestartUI();
        }

        if (transform.position.y <= -4.25) {
            // SceneManager.LoadScene(0);
            ShowRestartUI();
        }

        if (restartPanel.activeSelf && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame(); // Restart the game
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // SceneManager.LoadScene(0);
        

        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.layer == LayerMask.NameToLayer("Tree"))
        {
            // Show the restart UI instead of loading the scene immediately
            ShowRestartUI();
        }
    }

    private void ShowRestartUI()
    {
        restartPanel.SetActive(true); // Activate the restart panel
        Time.timeScale = 0;

    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // Reload the current scene
    }
}
