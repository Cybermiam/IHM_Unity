using System;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStatusManager2 : MonoBehaviour
{
    public GameObject ai1;

    public GameObject ai2;


    

    public TextMeshProUGUI playerLivesText;
    public TextMeshProUGUI aiLivesText;
    void Update()
    {
        int playerLives = ai1.GetComponent<AIController1>().lives;
        int aiLives = ai2.GetComponent<AIController2>().lives;

        playerLivesText.text = "Bot2 Lives: " + playerLives;
        aiLivesText.text = "Bot3 Lives: " + aiLives;

        if (playerLives <= 0 || aiLives <= 0)
        {
            
            UnityEngine.SceneManagement.SceneManager.LoadScene("GameOverWatch");
        }
        
    }

    
}
