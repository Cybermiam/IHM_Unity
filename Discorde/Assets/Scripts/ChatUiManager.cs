using System;
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
        this.text = text;
        Debug.Log("OnSendButtonClicked: " + this.text);
        textComponent.text = textComponent.text + "\nUser : " + text + "\n";
    }

    public void fightButtonPressed()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Battle");
    }
  
}
