using UnityEngine;

#if UNITY_EDITOR

using UnityEditor;

#endif


public class QuitMenuManager : MonoBehaviour
{

    public void QuitGame()
    {
        // Quit the game
        

        #if UNITY_EDITOR
    
            EditorApplication.ExitPlaymode();
        #endif

        Application.Quit();
    }


    public void CancelQuit()
    {
        // Load the main menu scene
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
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
