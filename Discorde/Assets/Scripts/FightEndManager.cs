using UnityEngine;

public class FightEndManager : MonoBehaviour
{
    public void returnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }

    public void returnToChat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameAfterWin");
    }
}
