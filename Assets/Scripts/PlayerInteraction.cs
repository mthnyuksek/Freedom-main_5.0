using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
private RescueRobot nearbyRobot;

    void Update()
    {
        if (nearbyRobot != null && Input.GetKeyDown(KeyCode.E))
        {
            nearbyRobot.Rescue();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("RescueRobot"))
        {
            nearbyRobot = other.GetComponent<RescueRobot>();
            UIManager.Instance.ShowRescuePrompt(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("RescueRobot"))
        {
            if (nearbyRobot != null)
            {
                nearbyRobot = null;
                UIManager.Instance.ShowRescuePrompt(false);
            }
        }
    }
}