using System;
using System.Collections;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChatUiManager : MonoBehaviour
{

    private string text;
    public TextMeshProUGUI textComponent;

    
    public void ReadStringInput(string text)
    {
        if(text == "")
        {
            return;
        }
        this.text = text;
        Debug.Log("OnSendButtonClicked: " + this.text);
        textComponent.text = textComponent.text + "\nUser : " + text + "\n";
        StartCoroutine(DelayedResponse());
    }

    public void fightButtonPressed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
    }

    public void returnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void watchGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Battle2");
    }
  
   private IEnumerator DelayedResponse()
    {
        yield return new WaitForSeconds(3); // Delay for 2 seconds
        textComponent.text = textComponent.text + "\nBot1 : Va toucher de l'herbe mec.\n";
    }
}
