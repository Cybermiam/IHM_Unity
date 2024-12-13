using System;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStatusManager : MonoBehaviour
{
    public GameObject player;

    public GameObject ai;


    

    public TextMeshProUGUI playerLivesText;
    public TextMeshProUGUI aiLivesText;
    void Update()
    {
        int playerLives = player.GetComponent<PlayerController>().lives;
        int aiLives = ai.GetComponent<AIController>().lives;

        playerLivesText.text = "Player Lives: " + playerLives;
        aiLivesText.text = "AI Lives: " + aiLives;

        if (playerLives <= 0)
        {
            
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverPlayerLost");
        }

        if (aiLives <= 0)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverPlayerWon");
        }
    }

    
}
