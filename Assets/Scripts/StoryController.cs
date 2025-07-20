using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryTeller : MonoBehaviour
{
    public GameObject storyPanel;
    public CanvasGroup canvasGroup;
    public float fadeDuration = 1.5f;
    public string nextSceneName = "level_1_tutorial";
    
    [Header("Müzik")]
    public AudioSource menuMusic;

    private bool isStoryPlaying = false;

    void Start()
    {
        if (menuMusic != null && !menuMusic.isPlaying)
        {
            menuMusic.loop = true;
            menuMusic.Play();
        }
    }

    public void PlayGame()
    {
        if (!isStoryPlaying)
        {
            Debug.Log("PlayGame çalıştı");
            StartCoroutine(ShowStory());
        }
    }

    private IEnumerator ShowStory()
    {
        isStoryPlaying = true;

        if (menuMusic != null)
        {
            menuMusic.Stop();
        }

        storyPanel.SetActive(true);
        yield return StartCoroutine(FadeCanvasGroup(canvasGroup, 0f, 1f));

        // Space tuşuna kadar bekle
        yield return StartCoroutine(WaitForSpaceKey());

        yield return StartCoroutine(FadeCanvasGroup(canvasGroup, 1f, 0f));
        storyPanel.SetActive(false);

        SceneManager.LoadScene(nextSceneName);
    }

    private IEnumerator WaitForSpaceKey()
    {
        while (!Input.GetKeyDown(KeyCode.Space))
        {
            yield return null;
        }
    }

    private IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end)
    {
        float elapsed = 0f;
        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            cg.alpha = Mathf.Lerp(start, end, elapsed / fadeDuration);
            yield return null;
        }
        cg.alpha = end;
    }
}
