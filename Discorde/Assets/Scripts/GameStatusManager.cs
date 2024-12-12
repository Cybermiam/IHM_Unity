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

    public GameObject popupPrefab;
    public Boolean gameOver = false;

    

    public TextMeshProUGUI playerLivesText;
    public TextMeshProUGUI aiLivesText;
    void Update()
    {
        int playerLives = player.GetComponent<PlayerController>().lives;
        int aiLives = ai.GetComponent<AIController>().lives;

        playerLivesText.text = "Player Lives: " + playerLives;
        aiLivesText.text = "AI Lives: " + aiLives;

        if (playerLives <= 0 || aiLives <= 0)
        {
            gameOver = true;
            Debug.Log("Game over condition met");
        }

        if (gameOver)
        {
            Debug.Log("Showing game over popup");
            ShowGameOverPopup();
        }
    }

    void ShowGameOverPopup()
    {
        Debug.Log("Game Over");

        GameObject popup = Instantiate(popupPrefab, transform);
        if (popup == null)
        {
            Debug.LogError("Popup prefab is not instantiated.");
            return;
        }

        Button quitToChatButton = popup.transform.Find("QuitToChatButton").GetComponent<Button>();
        Button quitToMainMenuButton = popup.transform.Find("QuitToMainMenuButton").GetComponent<Button>();

        if (quitToChatButton == null || quitToMainMenuButton == null)
        {
            Debug.LogError("Buttons not found in the popup prefab.");
            return;
        }

        quitToChatButton.onClick.AddListener(() => {
            SceneManager.LoadScene("Chat");
        });

        quitToMainMenuButton.onClick.AddListener(() => {
            SceneManager.LoadScene("MainMenu");
        });
    }
}
