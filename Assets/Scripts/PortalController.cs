using UnityEngine;
using System.Collections;

public class PortalController : MonoBehaviour
{

[SerializeField] private ScreenFader fader; // Inspector’dan referans ver






    public Sprite closedPortalSprite;
    public Sprite openPortalSprite;
    public string nextSceneName = "Level2"; // Geçilecek sahne adı

    private SpriteRenderer spriteRenderer;
    private bool isPortalActive = false;

        IEnumerator delay(float saniye)
    {
        yield return new WaitForSeconds(saniye);

        // Buraya bekledikten sonra yapilacak isi yaz
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closedPortalSprite; // Başlangıçta kapalı

        StartCoroutine(fader.FadeFromBlack());

      
    }

    public void ActivatePortal()
    {
        AudioManager.Instance.Play("PortalOpen");
        isPortalActive = true;
        spriteRenderer.sprite = openPortalSprite; // Sprite'ı açık hale getir
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isPortalActive && other.CompareTag("Player"))
        {
            StartCoroutine(delay(2));
            StartCoroutine(fader.FadeToBlack());
            Debug.Log("bu beklemeden yazmali");
        }
    }
}