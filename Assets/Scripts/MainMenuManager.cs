using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject storyPanel;
    public AudioSource storyAudio; // Hikaye sesi için
    public float storyDuration = 10f; // Panelin açık kalacağı süre

    public void OnPlayButtonClicked()
    {
        StartCoroutine(PlayStoryAndStartGame());
    }

    private IEnumerator PlayStoryAndStartGame()
    {
        storyPanel.SetActive(true);
        if (storyAudio != null)
        {
            storyAudio.Play();
        }

        yield return new WaitForSeconds(storyDuration);

        storyPanel.SetActive(false);
        SceneManager.LoadScene("level_1_tutorial");
    }
}