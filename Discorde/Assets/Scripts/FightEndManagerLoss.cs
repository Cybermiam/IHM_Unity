using UnityEngine;

public class FightEndManagerLoss : MonoBehaviour
{
    public void returnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenuAfterLoss");
    }

    public void returnToChat()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game");
    }
}
