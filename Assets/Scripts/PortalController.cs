using UnityEngine;

public class PortalController : MonoBehaviour
{
    public Sprite activePortalSprite;
    private SpriteRenderer sr;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    public void ActivatePortal()
    {
        sr.sprite = activePortalSprite;
    }
}