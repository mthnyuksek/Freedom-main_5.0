using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScreenFader : MonoBehaviour
{
    [SerializeField] private Image blackImage;    // Inspector’dan sürükleyip bırak
    [SerializeField] private float fadeDuration = 2f;  // Kaç saniyede kararsın

    private void Start()
    {
        // İstersen sahnenin hemen başında çalıştır:
        //StartCoroutine(FadeToBlack());
    }

    /// <summary>
    /// 0 → 1 alfa arası geçiş yaparak siyahı ekrana getirir
    /// </summary>
    public IEnumerator FadeToBlack()
    {
        float elapsed = 0f;
        Color c = blackImage.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            c.a = Mathf.Clamp01(elapsed / fadeDuration);
            blackImage.color = c;
            yield return null;
        }

        // Tamamen karardığında isteğe bağlı başka bir şey de yapabilirsin
    }



    /// <summary>
    /// Eğer tersine (karanlıktan açılır) ihtiyacın varsa:
    /// </summary>
    public IEnumerator FadeFromBlack()
    {
        float elapsed = 0f;
        Color c = blackImage.color;

        while (elapsed < fadeDuration)
        {
            elapsed += Time.deltaTime;
            c.a = 1f - Mathf.Clamp01(elapsed / fadeDuration);
            blackImage.color = c;
            yield return null;
        }
    }
}