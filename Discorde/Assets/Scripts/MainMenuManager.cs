using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // Load the game scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }


    public void QuitGame()
    {
        // Quit the game
        UnityEngine.SceneManagement.SceneManager.LoadScene("QuitPrompt");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
