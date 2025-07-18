using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathPanelManager : MonoBehaviour
{
    public void RetryLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentSceneName); // Şu anki sahneyi yeniden yükler
        Time.timeScale = 1f; // Oyunu devam ettir
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("main_menu"); // Ana menü sahnesinin adını gir
        Time.timeScale = 1f;
    }
}