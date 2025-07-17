using UnityEngine;

public class RobotInteraction : MonoBehaviour
{
    public GameObject interactionText; // UI Text "E'ye bas"
    private bool isPlayerNear = false;
    private bool isRescued = false;

    void Update()
    {
        if (isPlayerNear && !isRescued && Input.GetKeyDown(KeyCode.E))
        {
            isRescued = true;
            interactionText.SetActive(false);
            GameManager.Instance.RobotRescued();
            Destroy(gameObject); // robot sahneden kaybolur
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !isRescued)
        {
            interactionText.SetActive(true);
            isPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            interactionText.SetActive(false);
            isPlayerNear = false;
        }
    }
}