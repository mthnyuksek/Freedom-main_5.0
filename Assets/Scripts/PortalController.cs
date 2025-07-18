using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Sprite closedPortalSprite;
    public Sprite openPortalSprite;
    public string nextSceneName = "Level2"; // Geçilecek sahne adı

    private SpriteRenderer spriteRenderer;
    private bool isPortalActive = false;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = closedPortalSprite; // Başlangıçta kapalı
    }

    public void ActivatePortal()
    {
        isPortalActive = true;
        spriteRenderer.sprite = openPortalSprite; // Sprite'ı açık hale getir
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (isPortalActive && other.CompareTag("Player"))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
        }
    }
}